   M S B A M L   `   `   `  ����P  LTruckRentalManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:TruckRentalManagement.PresentationLayer'TruckRentalManagement.PresentationLayer  5   	   <    6TruckRentalManagement.PresentationLayer.AddNewCustomer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:TruckRentalManagement.PresentationLayer     5   	     � Title$  AddNewCustomer��5   	   $	��370��6    $	��300��6-   .��5	      �� ���#121212.+�5
   
   ��  �� Orientation$ 
Horizontal=�6   $��5q�6.   .+�5      �� $��Name:        ��6   
�������$��15(�6C   $��5q�6Q   �� 5      -   5        $��nameTextBox��5      $	��130��6)   $��15(�65   $��20��6C   5      �� 5   
   $ 
Horizontal=�6   $��5q�6.   .+�5      �� $��Address:     ��6   
�������$��15(�6C   $��5q�6Q   �� 5      -   5        $��addressTextBox��5      $	��130��6,   $��15(�68   $��20��6F   5      �� 5   
   $ 
Horizontal=�6   $��5q�6.   .+�5      �� $��Telephone: ��6   
�������$��15(�6A   $��5q�6O   �� 5      -   5        $��telephoneTextBox��5      $	��130��6/   $��15(�6;   $��20��6I   5      �� 5   
   $ 
Horizontal=�6   $��5q�6.   .+�5      �� $��License No: ��6   
�������$��15(�6B   $��5q�6P   �� 5      -   5        $��licenseNumberTextBox��5      $	��130��62   $��15(�6>   $��20��6L   5      �� 5   
   $ 
Horizontal=�6   $��5q�6.   .+�5      �� $��Age:            ��6   
�������$��15(�6F   $��5q�6T   �� 5      -   5        $��
ageTextBox��5      $	��130��6)   $��15(�65   $��20��6C   5      �� 5   
   $ 
Horizontal=�6   $��5q�6.   .+�5      �� $��License Exp:��6   
�������$��15(�6B   $��5q�6P   (  "System.Windows.Controls.DatePicker  5       -   5        $��licenseExpiryDatePicker��5       $
��Left=�68   $	��130��6T   $��15(�6`   $��30��6n   5!      ]� 5#   
   $	��250��6   $��5q�6    .+�5$      �� -   5        $��returnButton��5$      $��Return��6)   
�������$
��Left=�6M   $	��100��6h   $��40��6t   $
��Left=�6�   ��5%      �� 5&       �� 
TargetType" ��6   .�5'      ��  �� Property � �� �� Value �#27272767   �� 5(       � �� 5)      �� 5*   "    �� 
TargetType" ��62   .R�5+   &   �� #��z��6-   ._�5,   *   �� $��Center=�6;   $��Center=�6X   5-   '   5.   #   50       �� Triggers 51      P� 52       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �53   "   ��  � ��
 �OO/�6?   54      56      58      �� 59      -   5        $��addEmployeeButton��59      $��Add Customer��6.   
�������$	��100��6Y   $��40��6e   $��Right=�6�   $
��Left=�6�   $��15q�6�   ��5:      �� 5;      " ��6   .�5<      ��  � �� �#27272767   �� 5=       � �� 5>      �� 5?   "   " ��62   .R�5@   &   �� #��z��6-   ._�5A   *   �� $��Center=�6;   $��Center=�6X   5B   '   5C   #   5E       5F      P� 5G       �@J�IsMouseOver$
 True��6=   . �5H   "   ��  � ��
 �OO/�6?   5I      5K      5M      5N      5O      5P      