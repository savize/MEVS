   M S B A M L   `   `   `  ����?  ;MEVS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MEVSMEVS  5   	       MEVS.AdminLogged   5   	   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.64.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aa\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:MEVS     5   	     � Icon$  /ico.png��6+    � Title$ AdminLogged��5       � AllowsTransparency . 
������  � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�6.   $	��720��5
   	   $
��1280��6    � WindowStyle$
 None=�6#   .��5      ��  �� CornerRadius$ 35��6   ��5   
   �� 5       �� ImageSource$ Img\admin.jpg��6   ._�5   
   �  � RowDefinitions 5      �� 5      $	��150 �6    �� 5      �� 5      $��50 �6    .+�5      �� $��0��6   $
��Left=�6"   $ 
35,35,90,0��6=   ���	#7F030B11$
��1280��6n   $	��130��6{   $	��Top=�6�   ._�5      � .+�5      �� $��img\large.png��6   $
��Left=�5      $	��120��6/   $��70,0,0,0q�6;   �� 5      $��Welcome Admin��6   $��30(�65   $
��Bold"�6C   ���#FFFFFF$��Center=�6j   $��Center=�6�   �� 5      -   5        	 � Cursor$
	 Hand��5      $��/Img/adm.png��6*   $��50��6@   $��Right=�6K   $��0,0,60,0q�6g   6y   5      5      � 5       $��1��6   
 � ColumnDefinitions
 5!      �� 5"      $	��260 �6'   �� 5#      .+�5&      � $��0��6   .+�5'      �� $
��Left=�6   $	��250��69   $ 0,0,90,0��6E   $��	0,-20,0,0q�6]   ���	#7F030B11._�5(      � .+�5)      �� $	��330��6*   $	��Top=�67   $��0,70,0,0q�6O   .+�5*   "   �� $��Manage Users��6(   $��20(�6?   $
��Bold"�6M   ���#FFFFFF$��	50,10,0,0q�6t   �� 5+      -   5         ��Name$ EvOwnTab��5+   $   $��○  EV Owners��66   $
	 Hand��6M   $��18(�6[   $
��Bold"�6i   ���#C0F3F5$��	50,10,0,0q�6�   6�   �� 5,      -   5        $ CSTab��5,   $   $��○  Charging Stations��63   $
	 Hand��6R   $��18(�6`   $
��Bold"�6n   ���#C0F3F5$��	50,10,0,0q�6�   6�   �� 5-   "   -   5        $ SPTab��5-   (   $��○  Service Providers��67   $
	 Hand��6V   $��18(�6d   $
��Bold"�6r   ���#C0F3F5$��	50,10,0,0q�6�   6�   �� 5.   "   $��Maintenance��6(   $��20(�6>   $
��Bold"�6L   ���#FFFFFF$��	50,10,0,0q�6s   �� 5/   "   -   5        $ bk��5/   (   $��○  Backup Data��64   $
	 Hand��6M   $��18(�6[   $
��Bold"�6i   ���#C0F3F5$��	50,10,0,0q�6�   6�   �� 50   "   -   5        $
 rest��50   (   $��○  Restore Data��66   $
	 Hand��6P   $��18(�6^   $
��Bold"�6l   ���#C0F3F5$��	50,10,0,0q�6�   6�   52      �� 53      $��0,70,0,0q�6)   $
��Left=�6;   .+�54   "   �� $��30��6(   $��/Img/UsMan.png��63   $	��Top=�6K   $��	13,10,0,0q�6c   �� 55   "   $��30��6(   $��/Img/Bk.png��63   $	��Top=�6H   $��
13,152,0,0q�6`   57      58      59      5:      � 5;      -   5         �Name$ mainCon��5;   '   $��1��6   $y�Hidden=�68    5<      �� 5=      $��40 �6(   �� 5>      �� 5?      $��70 �6(   .+�5A      �� ���	#9909ACA7$	��980��64   $
��Left=�6@   $ 	0,35,0,35��6[   ._�5B      �� $��Center=�6    $<��6Double click on any item to deactive the selected one.��6D   $��20(�6�   ���#FFFFFF6�   5C      &   System.Windows.Controls.DataGrid  5E      -   5          Name$ Dg��5E      $��1��6+   $��20,20,60,30q�68   $��13(�6M      CanUserAddRows .     CanUserDeleteRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      MaxColumnWidth$	 940Q�6�      
IsReadOnly . 6�   �� 5F      -	   5         ��Name$	 btn��5F   2   $��-240,0,0,20q�6   $��2��6?   $��Export Report��6L   $��20(�6d   $
��Bold"�6r   $
	 Hand��6�   $	��230��6�   ���#09ACA7 
  BtnHov#���   6�   6�   5G      5K      5L      5M      5N      