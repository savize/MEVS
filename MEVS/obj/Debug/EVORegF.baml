   M S B A M L   `   `   `  ����?  ;MEVS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MEVSMEVS  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       MEVS.EVORegF   5   	   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.64.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aa\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:MEVS     5   	   +beclr-namespace:BE;assembly=BE     5   	     � AllowsTransparency  . 
������  � Title$ EVORegF��5	   	   $	��450��6   $	��580��6&    � WindowStartupLocation$ CenterScreen=�62    � 
ResizeMode$ NoResize=�6W    � WindowStyle$
 None=�5
   	   .��5      ��  �� CornerRadius$ 35��6   ���#C0F3F5._�5   
   � $��	0,20,0,20q�6   $	��550��6"    � RowDefinitions 5      �� 5      $��80 �6    �� 5      �� 5      �� 5      �� 5      �� 5      $��80 �6     � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      .+�5      �� -   5        $��/Img/close.png��5      $��30��6,    � Cursor$
 Hand��67   $��Right=�6E   $	��Top=�6a   $��1��6y   6�   �� 5      $��2��6   $ ��EV Owner Registration Form��6)   ���#0B2C44$��20(�6c   $��Center=�6q   $
��Bold"�6�   �� 5      $��2��6   $��	0,30,0,10q�6(   $)��#Please fill up the requested fields��6;   ���#0B2C44$��20(�6~   $��Center=�6�   �� 5!      $��1��6   $��Vehicle Brand :��6!   ���#0B2C44$��15(�6P   $��Center=�6^   $��Center=�6y   �� 5"      $��2��6   $��Vehicle Model :��6!   ���#0B2C44$��15(�6P   $��Center=�6^   $��Center=�6y   �� 5#      $��3��6   $��Bank Account :��6!   ���#0B2C44$��15(�6O   $��Center=�6]   $��Center=�6x   �� 5$      $��4��6   $��	Address :��6!   ���#0B2C44$��15(�6J   $��Center=�6X   $��Center=�6s   �� 5&      -   5        	 ��Name$	 brandComboBox��5&      $��10q�6.   $��1��5'      $��1��6$   $	��250��64   $��30��6@   $
��Left=�6L   $��15(�6g   
 �� SelectedIndex$
 1��6u   ��5&   :   ��   
BE.Vehicle   
BrandNames �� Source# Z 5'   �   �� 5*      $��2��6   $��1��6"   $
��Left=�63   
�������$ 12��6b   $��35��6t   $	��250��6�   ._�5+      �� -   5         ��Name$ 
modelValue��5+      
������ $	��235��6G   $��25��6S   $��0q�6_   $��15(�6s   5,      �� 5.      $��3��6   $��1��6"   $
��Left=�62   
�������$	��250��6a   $��35��6m   $ 12��6y   ._�5/      �� -   5        $ 	bankValue��5/      
������ $	��235��6F   $��25��6R   $��0q�6^   $��15(�6r   50      �� 52      $��4��6   $��1��6"   $
��Left=�62   
�������$ 12��6a   $	��250��6s   $��35��6   ._�53      �� -   5        $ addressValue��53      
������ $	��235��6I   $��25��6U   $��0q�6a   $��15(�6u   54      �� 56      -   5        $��5��56      $��2��6"   $��Center=�66   $��Register��6S   $��20(�6f   $
��Bold"�6t   $
 Hand��57      $��40��6   $	��280��6(   $��0,30,0,5q�64   ���#0B2C44 
  BtnHov#���   6[   6|   59      5:      5;      