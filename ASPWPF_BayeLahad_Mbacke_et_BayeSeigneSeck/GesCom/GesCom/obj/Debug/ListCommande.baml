   M S B A M L   `   `   `  ����A  =GesCom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GesComGesCom  5   	       GesCom.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:GesCom     5   	   -   5          � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      � $��
6,0,-6,-16q�6    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $	��381 �6   �� 5      �� 5      $��60 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	dataGrid1��5      $��51,0,10,255q�6P   $��2��6e   $��2��6y   �� 5   
   $	��Top=�6   $��30��6W   $��30��6b   $��0q�6n   $��Modifier��6z   $
��Left=�6�   $��	70,44,0,0q�6�   $��2��6�    J� RenderTransformOrigin$ 1.144,-0.328&�6�   ��6*   Z� ��6@   Z� 6�   �� 5   
   $��Enregistrer��6   $
��Left=�6'   $��
118,44,0,0q�6B   $��2��6V   $	��Top=�6c   $��21��6{   $��66��6�   �� 5   
   $��Annuler��6   $��Center=�6#   $��0,44,0,0q�6@   $��2��6R   $	��Top=�6_   $ 0.048,0.069&�6w   $��21��6�   $��49��6�   �� 5   
   $��Fermer��6   $
��Left=�6"   $��
212,44,0,0q�6=   $��2��6Q   $	��Top=�6^   $��21��6v   $��44��6�   �� 5   
   $��1��6   $��Center=�6"   $��	0,165,0,0q�6?    �� TextWrapping$
 Wrap=�6R   $��TextBox��6f   $	��Top=�6u   $	��120��6�   $��25��6�   $��2��6�   �� 5   
   $��1��6   $��
Rechercher��6!   $
��Left=�66   $��247,165,0,0q�6Q   $	��Top=�6f   $ 0.341,0.108&�6~   $��25��6�   $	��112��6�   ���	#FF64CCF1
�������$��Arial)�5      $��20(�5      $��2��6     5   
   $��51,203,0,10q�6>   $��2��6S   $��2��6`    � 	Resources 5!      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5"      "  6   .�5#      ��  � ��
 ��� �63   �� 5$       � ��$ SemiBold"�63   �� 5%       � ��$ 0,0,1,2q�68   �� 5&       � ��
 �   �64   5'      5(      	   Columns	 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Order ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 67     5+      $
 
Order Date��6%   $	 150 69     5,      $
 Customer ID��6%   $	 150 6:     5-      $
 	ShipeName��6%   $	 150 68   5/      50      51      