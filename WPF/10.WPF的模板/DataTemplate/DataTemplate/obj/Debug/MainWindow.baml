   M S B A M L   `   `   `  ����G  CDataTemplate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DataTemplateDataTemplate  5   	       DataTemplate.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DataTemplate     5   	     � Title$#  豪车展台 Use DataTemplate��5   	   $	��350��6'   $	��650��64    � 	Resources 5         DataTemplate.NameToLogo   ntl   DataTemplate.NameToImage  nti  detailTemplate �� CornerRadius �� 	Converter �� Orientation  logoTemplate��%�  &	        &	      &	 &     7  &	 9    7     5   
   6     5   
   6   �� 5   
   .R�5      �� 
���   �$��1q�6)   $ 6��6=   ._�5      �� $��5q�6   .+�5      �� $	��400��6   $	��250��6(   ��65   �� *Name+8   �� 5      $ 
Horizontal=�6!   $	��5,0q�6:   .+�5      �� $��	名称：��6$   $
��Bold"�6/   $��20(�6A   �� 5      $��20(�6:   $	��5,0q�6H   ��6$   �� *Name+6H   5      �� 5      $ 
Horizontal=�6!   $	��5,0q�6:   .+�5      �� $��	产地：��6$   $
��Bold"�6/   �� 5      $	��5,0q�6;   ��6$   �� *Area+6;   �� 5      $��	年份：��6$   $
��Bold"�6/   �� 5      $	��5,0q�6;   ��6$   �� *Year+6;   �� 5      $��	时速：��6$   $
��Bold"�6/   �� 5      $	��5,0q�6<   ��6$   �� *Speed+6<   5      5       5!      5"      �� 5$   
   .R�5%      � $��2q�6   .+�5&      �� $ 
Horizontal=�6   .+�5'      �� $��3��6S   $��64��6d   $��64��6o   ��6   �� *Name+8   6o   �� 5(      $	��5,0q�6!   .+�5)      �� $��16(�6:   $
��Bold"�6H   ��6$   �� *Name+6H   �� 5*      $��14(�6:   ��6$   �� *Year+6:   5+      5,      5-      5.      5/      .��52      �� $ 
Horizontal=�6   $��5q�6*   .+�53   
   >� #��[ 6   ��6H   �� *SelectedItem+ �� ElementName$ lb_car���� 54   
   -   5         ��Name$ lb_car��54      $	��200��6"   $	��5,0q�6.   #��[ 6;   55      56      