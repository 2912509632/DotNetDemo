   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections  5   	   Y U检索DataTemplate内部控件, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:检索DataTemplate内部控件检索DataTemplate内部控件 5   	   /   )检索DataTemplate内部控件.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @c2clr-namespace:System.Collections;assembly=mscorlib     5   	   >local,clr-namespace:检索DataTemplate内部控件     5   	     � Title$$  检索DataTemplate内部控件��5	   	   $	��300��6$   $	��300��61   
��� ��� � 	Resources 5      "   System.Collections.ArrayList   data,  &检索DataTemplate内部控件.Student   Name   Skill   HaveJob  dt_Name ��Name  dt_Skill  
dt_HaveJob ��Name d� 	IsChecked��%l  &	        &	 �    &	 u    &	 �      5   
     5      $ Jiuone��6   $ DotNet��6*    .  69     5      $ HackPlay��6   $ DotNet��6,    .  6;     5      $ Liangrui��6   $
 Java��6,    . 69     5      $	 Lsx��6   $ Network��6'    . 67     5      $
 Xiao��6   $
 Safe��6(    . 65     5      $ Laowei��6   $
 ZHBX��6*    . 67     5      $ Hmister��6   $ C��6+    .  65     5      $ MxyVip��6   $ DotNet��6*    .  69   5      �� 5   
   .R�5      �� $ txt_name��6   -   5        $��90��5   >   ��6(   �� *Name+6I   5      �� 5   
   .R�5      �� $ 	txt_skill��6   $��90��6@   ��6)   �� *Skill+6@   5      �� 5    
   .R�5!      �� $ cb_job��6   $��40��6E    6'   �� *	HaveJob+6E   5"      5#      .��5&      � $��5q�6   .+�5'   
   �� -   5         ��Name$ lv_demo��5'      #��[  6$   	 �� View	 5(      �� 5)      .P�5*      �� 
 �� CellTemplate#
 [ 6%   $��姓名��6M   �� 5+      #
 [ 6%   $��技能��6N   �� 5,      #
 [ 6%   $��是否工作��6P   5-      5/      50      51      