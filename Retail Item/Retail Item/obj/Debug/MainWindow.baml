   M S B A M L   `   `   `  ����F  BRetail Item, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Retail_ItemRetail_Item  5   	       Retail_Item.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Retail_Item     5   	     � Title$  Retail Items��5   	   $	��450��6   $	��800��6+   
������� � 	Resources 5
         Retail_Item.MoneyConverter 	  Money��%   &	          5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��4* �6   .+�5   
   �� $#��Displaying Retail Store Items��6   $��Center=�68   $��35(�6\   $��Italic$�6j   
����  �6}   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��Center=�6;   .+�5      �� $��Description��6   
����  �$��1��6?   $��20(�6L   $	��200��6Z   $
��Bold"�6f   $��Center=�6x   $��Center=�6�   �� 5      $��Unit On Hand��6   
����  �$��1��6@   $	��200��6M   $��20(�6Y   $
��Bold"�6g   $��Center=�6y   $��Center=�6�   �� 5      $��Price��6   
����  �$��1��69   $	��200��6F   $��20(�6R   $
��Bold"�6a   $��Center=�6s   $��Center=�6�   5      �� 5   
   -   5        $��5q�5   6   $��2��6A   $��25(�5      
����  �$��3q�6.   $	��630��6B   ��5      �� *RetailItems+��5      �� 5      .R�5      �� $ 
Horizontal=�6!   .+�5       �� $	��200��6    $��Center=�6L   ��6,   �� *Description+6L   �� 5!      $	��200��6    $��Center=�6K   ��6,   �� *
UnitOnHand+6K   �� 5"      $	��150��6    $��0 0 50 0q�6h   $��Right=�6z   ��6,   �� *Price+ �� 	Converter# [  6z   5#      5$      5&      5'      5(      