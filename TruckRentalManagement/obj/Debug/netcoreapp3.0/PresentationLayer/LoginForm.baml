   M S B A M L   `   `   `  ����P  LTruckRentalManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:TruckRentalManagement.PresentationLayer'TruckRentalManagement.PresentationLayer  5   	   7    1TruckRentalManagement.PresentationLayer.LoginForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:TruckRentalManagement.PresentationLayer     5   	     � Title$  	LoginForm��5   	    � 
ResizeMode$ NoResize=�6   $	��340��61   $	��300��6>   .��5	      �� ���#121212.+�5
   
   �� $��1q�6   
�������$��70��69   $	��224��6E   $��5q�6Q   ._�5      �� $��Login��6   $��40(�6$   $
��Bold"�62   
�������$��Center=�6[   5      �� 5   
   $��	Username:��6   $��25(�6$   $
��Bold"�62   
�������$
��Left=�6[   �� 5   
   -   5        $��userNameTextBox��5       �� TextWrapping$
 Wrap=�6)   $��20(�6=   ���#272727
�������$	��168��6w   $��28��6�   �� 5   
   $��	Password:��6   $��25(�6$   $
��Bold"�62   
�������$
��Left=�6[   G� 5   
   -   5        $��passwordBox��5      $��20(�6)   ���#272727
������� G� 	MaxLength$ 25��6e    G� PasswordChar$ *��6t   $	��168��6�   $��28��6�   �� 5   
   $��15(�6   $
��Bold"�6   
�������$
��Left=�6G   $��9q�6b   ]� 5   
   $	��250��6   .+�5      �� -   5        $��closeButton��5      $��Close��6(   
�������$
��Left=�6K   $	��100��6f   $��40��6r   $
��Left=�6~   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value �#27272767   �� 5       � �� 5      �� 5   "    �� 
TargetType" ��62   .R�5   &   �� #��z��6-   ._�5   *   �� $��Center=�6;   $��Center=�6X   5   '   5   #   5      	 �� Triggers	 5       P� 5!      
 P� Property
 �@J�IsMouseOver P� Value$
 True��6=   . �5"   "   ��  � ��
 �OO/�6?   5#      5%      5'      �� 5(      -   5        $��loginButton��5(      $��Login��6(   
�������$��Right=�6K   $	��100��6g   $��40��6s   $
��Left=�6   ��5)      �� 5*      " ��6   .�5+      ��  � �� �#27272767   �� 5,       � �� 5-      �� 5.   "   " ��62   .R�5/   &   �� #��z��6-   ._�50   *   �� $��Center=�6;   $��Center=�6X   51   '   52   #   54      	 55      P� 56      
 �@J�IsMouseOver$
 True��6=   . �57   "   ��  � ��
 �OO/�6?   58      5:      5<      5=      5>      5?      