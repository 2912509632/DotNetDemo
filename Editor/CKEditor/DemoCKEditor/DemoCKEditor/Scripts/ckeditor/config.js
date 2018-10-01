/**
 * CKEditor 配置信息
 */

CKEDITOR.editorConfig = function( config ) {
    //在此处定义对默认配置的更改。
    // 完整参考请参阅：
	// http://docs.ckeditor.com/#!/api/CKEDITOR.config

    // 工具栏组排列，针对两个工具栏行进行了优化。
	config.toolbarGroups = [
		{ name: 'clipboard',   groups: [ 'clipboard', 'undo' ] },
		{ name: 'editing',     groups: [ 'find', 'selection', 'spellchecker' ] },
		{ name: 'links' },
		{ name: 'insert' },
		{ name: 'forms' },
		{ name: 'tools' },
		{ name: 'document',	   groups: [ 'mode', 'document', 'doctools' ] },
		{ name: 'others' },
		'/',
		{ name: 'basicstyles', groups: [ 'basicstyles', 'cleanup' ] },
		{ name: 'paragraph',   groups: [ 'list', 'indent', 'blocks', 'align', 'bidi' ] },
		{ name: 'styles' },
		{ name: 'colors' }
	];

    // 删除标准插件提供的一些按钮，它们是
    // 标准工具栏中不需要。
	config.removeButtons = 'Underline,Subscript,Superscript';

    //设置最常见的块元素。
	config.format_tags = 'p;h1;h2;h3;pre';

    // 简化对话窗口。
	config.removeDialogTabs = 'image:advanced;link:advanced';

    //语言设置
	config.language = 'zh-cn';

    //界面颜色
	config.uiColor = '#F2F2F2';
};
