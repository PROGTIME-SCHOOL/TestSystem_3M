   M S B A M L   `   `   `  ����H  DTestSystem_3M, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TestSystem_3MTestSystem_3M  5   	       TestSystem_3M.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TestSystem_3M     5   	     � Title$  Test System v1.0��5   	   $	��450��6"   $	��800��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $��60 �6   �� 5      �� 5      $��60 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $	��100��5      $��15q�6!   $��Results��6-   6?   �� 5      $	��100��6   $��15q�6#   �� 5      -   5        $	��100��5      $��15q�6!   $��START��6-   
��� ���
�������5   (   5      �� 5   
   $��1��6   .+�5      �� -   5        $��txtQuestion��5      $��QUESTION��6+   $��Center=�6;   $��0 50 0 0q�5      $��30(�6*   �� 5      $ 
Horizontal=�6   $��Center=�62   .+�5      �� -   5        $��btnYes��5      $	��100��6'   $	��100��63   $��	0 60 20 0q�6@   $	��YES��6S   $��20(�5      
��� � �
�������5      �� 5       -   5        $��btnNo��5       $	��100��6&   $	��100��62   $��	20 60 0 0q�6?   $��NO��6R   $��20(�5!      
��� E��
�������5"      5#      5$      �� 5&   
   $��2��6   $ 
Horizontal=�6"   $��Bottom=�6;   .+�5'      �� -   5        $��lblInfo��5'      $��Information��6#   $��15q�69   5(      5)      5*      