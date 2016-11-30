function GridHelper(option) {

    var defaultOption = {
        grid: undefined,
        idColumn: 'Id',
        addButtonId: 'btnAdd',
        titileColumn: 'Id',
        viewLinkName: 'viewLink',
        editLinkName: 'editLink',
        deleteLinkName: 'deleteLink',
        addUrl: '',
        viewUrl: '',
        editUrl: '',
        deleteUrl: '',
        editLinkText: '修改',
        deleteLinkText: '删除',
        addButtonClick: defaultAddClick,
        viewLinkClick: defaultViewLinkClick,
        editLinkClick: defaultEditLinkClick,
        deleteLinkClick: defaultDeleteLinkClick,
        dialogDiv: '',
        titleHandler: undefined,
        dialogWidth: 800,
        afterGridComplete: undefined
    };

    option = jQuery.extend(defaultOption, option);

    if (!option.grid) {
        alert("没有指定grid！");
        return;
    }

    var dialogDiv = option.dialogDiv;

    //jqgrid加载完成后
    this.gridComplete = function () {
        var viewLink = $("a[name='" + option.viewLinkName + "']");
        var editLink = $("a[name='" + option.editLinkName + "']");
        var deleteLink = $("a[name='" + option.deleteLinkName + "']");
        var addLink = $('#' + option.addButtonId);

        //查看链接
        viewLink.unbind('click');
        viewLink.bind('click', function () {
            var rowData = getRowData($(this).attr("rowIndex"));
            option.viewLinkClick(rowData);
        });

        //修改链接
        editLink.unbind('click');
        editLink.bind('click', function () {
            var rowData = getRowData($(this).attr("rowIndex"));
            option.editLinkClick(rowData);
        });

        //删除链接
        deleteLink.unbind('click');
        deleteLink.bind('click', function () {
            var rowData = getRowData($(this).attr("rowIndex"));
            option.deleteLinkClick(rowData);
        });

        //新增按钮
        addLink.unbind('click');
        addLink.bind('click', function () {
            option.addButtonClick();
        });

        if (option.afterGridComplete) {
            option.afterGridComplete();
        }
    };

    //创建查看链接
    this.createViewLink = function (cellvalue, options, rowData) {
        return "<a href='#' name='" + option.viewLinkName + "' rowIndex='" + options.rowId + "' style='color:#f60'>" + cellvalue + "</a>";
    };

    //创建修改链接
    this.createEditLink = function (cellvalue, options, rowData) {
        return "<a href='#' name='" + option.editLinkName + "' rowIndex='" + options.rowId + "' style='color:#f60'>" + option.editLinkText + "</a>";
    };

    //创建删除链接
    this.createDeleteLink = function (cellvalue, options, rowData) {
        return "<a href='#' name='" + option.deleteLinkName + "' rowIndex='" + options.rowId + "' style='color:#f60'>" + option.deleteLinkText + "</a>";
    };

    //新增按钮
    function defaultAddClick() {
        createModelDialog(dialogDiv, "新建", option.dialogWidth, null, option.grid);
        dialogDiv.load(option.addUrl, function () {
            setDialogCenter(dialogDiv);
        });
    }

    function defaultViewLinkClick(rowData) {
        var id = getColumnValue(rowData, option.idColumn);
        var cellValue = $(this).text();
        createModelDialog(dialogDiv, "查看", option.dialogWidth, null, option.grid);
        dialogDiv.load(option.viewUrl + '/' + id, function () {
            setDialogCenter(dialogDiv);
        });
    }

    function defaultEditLinkClick(rowData) {
        var id = getColumnValue(rowData, option.idColumn);
        createModelDialog(dialogDiv, "编辑", option.dialogWidth, null, option.grid);
        dialogDiv.load(option.editUrl + '/' + id, function () {
            setDialogCenter(dialogDiv);
        });
    }

    function defaultDeleteLinkClick(rowData) {
        var title = getColumnTitle(rowData);
        if (!confirm("确定要删除【" + title + "】?")) {
            return false;
        }
        var id = getColumnValue(rowData, option.idColumn);
        $.get(option.deleteUrl + "/" + id, function (result) {
            if (result == "ok") {
                alert("删除成功！");
                option.grid.jqGrid().trigger("reloadGrid");
            }
            else {
                alert(result);
            }
        });
        return false;
    }

    function getRowData(rowIndex) {
        return option.grid.jqGrid().getRowData(rowIndex);
    }

    function getColumnValue(rowData, columnName) {
        for (var p in rowData) {
            if (p == columnName) {
                return rowData[p];
            }
        }
    }

    function getColumnTitle(rowData) {
        if (option.titleHandler) {
            return option.titleHandler(rowData);
        }
        return getColumnValue(rowData, option.titileColumn);
    }

    //以下是格式化辅助函数
    this.formatBool = function (cellvalue, options, rowData) {
        return cellvalue ? '是' : '否';
    };

}

//创建对话框
function createModelDialog(dialogDiv, title, width, height, grid) {
    var lodingHtml = '<div style="text-align: center;">' +
                     '<img src="/Images/ajax-loader.gif" alt="加载中..." title="加载中..." />' +
                     '<br />' +
                     '<span>加载中，请稍后...</span>' +
                     '</div>';
    dialogDiv.html(lodingHtml);
    dialogDiv.dialog({
        modal: true,
        width: width,
        title: title,
        draggable: true,
        resizable: false,
        beforeClose: function () {
            if (grid) {
                grid.trigger("reloadGrid");
            }
            dialogDiv.dialog('destroy');
        }
    });
};

function setDialogCenter(dialogDiv) {
    dialogDiv.dialog("option", "position", { my: "center", at: "center", of: window });
}


