/**
 * CKEditor ������Ϣ
 */

CKEDITOR.editorConfig = function( config ) {
    //�ڴ˴������Ĭ�����õĸ��ġ�
    // �����ο�����ģ�
	// http://docs.ckeditor.com/#!/api/CKEDITOR.config

    // �����������У���������������н������Ż���
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

    // ɾ����׼����ṩ��һЩ��ť��������
    // ��׼�������в���Ҫ��
	config.removeButtons = 'Underline,Subscript,Superscript';

    //��������Ŀ�Ԫ�ء�
	config.format_tags = 'p;h1;h2;h3;pre';

    // �򻯶Ի����ڡ�
	config.removeDialogTabs = 'image:advanced;link:advanced';

    //��������
	config.language = 'zh-cn';

    //������ɫ
	config.uiColor = '#F2F2F2';
};
