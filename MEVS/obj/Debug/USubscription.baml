   M S B A M L   `   `   `  ����?  ;MEVS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MEVSMEVS  5          MEVS.USubscription   5      ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.64.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aa\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:MEVS     5      .��5	      �� -   5        ���	#BF09ACA7  �� CornerRadius$  
0,90,90,90��5	   $   $	��Top=�6>   $
��Left=�6V   $	��940��6q   $	��480��6}   ._�5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � -   5         �Name$ Subsc��5      .+�5      �� $	��800��6   $��
-20,20,0,0q�6'   $��Current Subscribed Plan��6;   $��18(�6\   ���#FFFFFF$
��Bold"�6   .��5      �  5      �� 5      $��10 �6,   �� 5      �� 5      �� 5      �� 5      $��10 �6,    � ColumnDefinitions 5      �� 5      $��20 �6/   �� 5      $	��200 �6/   �� 5      �� 5      �� 5      .+�5       �� $��1��6    $��1��6-   $��Company Name :��6=   $	��Top=�6V   ���#C0F3F56n   �� 5!      -   5         ��Name$ CompName��5!   =   $��1��6    $��2��6-   $��SP Name��6O   $��Normal"�6a   ���#FFFFFF6u   �� 5"      $��2��6    $��1��6-   $��Plan Type :��6=   $
��Bold"�6S   $	��Top=�6e   ���#C0F3F56}   �� 5#      -   5        $ PTitle��5#   =   $��2��6    $��2��6-   $
��Type��6M   $��Normal"�6\   ���#FFFFFF6p   �� 5$      $��3��6    $��1��6-   $��Plan Length(months) :��6=   $
��Bold"�6]   $	��Top=�6o   ���#C0F3F56�   �� 5%      -   5        $ Lenght��5%   =   $��3��6    $��2��6-   $��Length��6M   $��Normal"�6^   ���#FFFFFF6r   �� 5&      $��1��6    $��3��6-   $��Detail :��6=   $
��Bold"�6P   $	��Top=�6b   ���#C0F3F56z   �� 5'      -   5        $ descr��5'   _   $��1��6    $��4��6-   $��
-100,0,0,0q�6=   $��11(�6Q   $
��Type��6n   $��Normal"�6}   ���#FFFFFF6�   �� 5(      $��2��6    $��3��6-   $��Purchased on :��6=   $
��Bold"�6V   $	��Top=�6h   ���#C0F3F56�   �� 5)      -   5        $ PurchD��5)   =   $��2��6    $��4��6-   $
��Date��6M   $��Normal"�6\   ���#FFFFFF6p   �� 5*      $��3��6    $��3��6-   $��Remaining Days :��6=   $
��Bold"�6X   $	��Top=�6j   ���#C0F3F56�   �� 5+      -   5        $ RemDays��5+   =   $��3��6    $��4��6-   $��X Days��6N   $��Normal"�6_   ���#FFFFFF6s   5-      5.      5/      � 50      -	   5        $ NotSubsc��50      .+�51      �� $-��'You are not subscribed to any plan yet.��6   $
��Bold"�6J   $	��Top=�6\   $��20(�6t   ���#C0F3F5$��	70,10,0,0q�6�   �� 52      $;��5Double click on any plan bellow to Pay and Subscribe.��6   $��20(�6X   ���#FFFFFF$��	70,40,0,0q�6{   $
��auto��6�   53      &   System.Windows.Controls.DataGrid  54      -
   5          Name$ plansDG��54      $��1��6(   $	��800��65   $	��230��6A   $	��Top=�55      $
��Left=�6/   $��	60,20,0,0q�6J   $��13(�56         CanUserAddRows .     CanUserDeleteRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 57   0   	   MaxColumnWidth$		 800Q�6@   
   
IsReadOnly
 . 58      5:      5;      5<      