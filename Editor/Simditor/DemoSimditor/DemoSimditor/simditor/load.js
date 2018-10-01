//全局编辑器对象
var editor;

//simdtor上级目录设置
var simditor_src = "/";

//配置初始化
function SimditorInit() {
    //工具栏对象
    var mToolbar, toolbar;
    toolbar = ['title', 'bold', 'italic', 'underline', 'strikethrough', 'fontScale', 'color', '|', 'ol', 'ul', 'blockquote', 'code', 'table', '|', 'link', 'image', 'hr', '|', 'indent', 'outdent', 'alignment'];
    mToolbar = ["bold", "underline", "strikethrough", "color", "ul", "ol", "blockquote"];
    //移动端检查
    if (mobilecheck()) {
        toolbar = mToolbar;
    }
    //实例化编辑器对象
    editor = new Simditor({
        textarea: $('#editor'),  //texteare设定
        placeholder: '这里输入正文内容...', //内容提示
        defaultImage: simditor_src + 'simditor/img/error.png', //图片错误替换图片
        pasteImage: false, //是否支持粘贴板图片上传
        toolbar: toolbar, //初始化工具栏
        upload: //图片上传设定
            {
                url: '/Home/UpImg',  //文件上传的接口地址  
                fileKey: 'upImg', //服务器端获取文件数据的参数名  
                connectionCount: 1, //同时上传文件数
                leaveConfirm: '文件正在上传中,请不要离开！' //中断上传操作提示
            },
        params: //在textarea中插入一个隐藏的输入来存储参数（键值对）
            {
            }
    });
}

//获取编辑器HTML内容
function getEditorVal()
{
    return $(".simditor-body").html();
}

//加载资源
$(function () {
    //加载样式表
    $("<link>").attr({
        rel: "stylesheet",
        type: "text/css",
        href: simditor_src + "simditor/css/simditor.min.css"
    }).appendTo("head");

    //加载脚本文件
    $.getScript(simditor_src + "simditor/module.min.js");
    $.getScript(simditor_src + "simditor/plugin/mobilecheck.min.js");
    $.getScript(simditor_src + "simditor/simditor.min.js", function () {
        SimditorInit();
    });
    $.getScript(simditor_src + "simditor/plugin/hotkeys.min.js");
    $.getScript(simditor_src + "simditor/plugin/uploader.min.js");
});