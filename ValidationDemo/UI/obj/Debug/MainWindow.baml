   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	       UI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � -   5        $��grdData��5	       � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� -   5         ��Name$ 	textBlock��5      $
��Wrap=�6'   $	��Id:��6;   $��6q�6F   �� 5   
   -   5        $ 
textBlock1��5      $��1��6(   $
��Wrap=�65   $��First Name:��6I   $��6q�6\   �� 5   
   -   5        $ 
textBlock2��5      $��2��6(   $
��Wrap=�65   $��	Last Name��6I   $��6q�6Z   �� 5   
   -   5        $ 
textBlock3��5      $��1��6(   $
��Wrap=�68   $��6q�6e   ��6L   ��  �� Path$ ID�6e   �� 5   
   -   5         ��Name$ textBox��5   4      overlay#��[  6   $��1��6E   $��1��6U    �� TextWrapping$
 Wrap=�6b   $��6q�6�   ��6v   �� $ 	FirstName� �� ValidatesOnDataErrors . 6�   �� 5   
   -   5        $ textBox1��5   9     exceloverlay#��[ 6   $��1��6K   $��2��6[   $
 Wrap=�6h   $��6q�6�   ��6|   �� $ LastName� . 6�   �� 5   
   -   5         ��Name$ button��5      $��Button��6!   $��1��62   $
��Left=�6B   $��
360,10,0,0q�6]   $��3��6q   $	��Top=�6~   $��75��6�   5      5      