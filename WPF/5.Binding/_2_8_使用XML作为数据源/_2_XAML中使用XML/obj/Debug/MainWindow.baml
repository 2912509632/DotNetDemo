   M S B A M L   `   `   `  ����N  J_2_XAML中使用XML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:_2_XAML中使用XML_2_XAML中使用XML  5   	   $    _2_XAML中使用XML.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:_2_XAML中使用XML     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��180��6)    � 	Resources 5	         provider � XPath��%�  &	        � 5
   
   $ Root/Package��6+   .��5      ��<Root xmlns="">
                    <Package Name="求索楼">
                        <Package Name="2-2404" />
                        <Package Name="2-2505" />
                        <Package Name="2-2201" />
                        <Package Name="2-2403" />
                    </Package>
                    <Package Name="修远楼">
                        <Package Name="2-2404" />
                        <Package Name="2-2505" />
                        <Package Name="2-2201" />
                        <Package Name="2-2403" />
                    </Package>
                    <Package Name="逸夫楼">
                        <Package Name="2-2404" />
                        <Package Name="2-2505" />
                        <Package Name="2-2201" />
                        <Package Name="2-2403" />
                    </Package>
                </Root>        5!      5"      .��5$      � .+�5%   
   R� ��6   ��  �� Source# [  ��5&      �� 5'       �� ItemsSource 6+   ��  �� XPath$ Package��.R�5(      �� ��6    �� $ @Name��5)      5+      5,      5-      