   M S B A M L   `   `   `  ����P  LTruckRentalManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TruckRentalManagementTruckRentalManagement  5   	   +    %TruckRentalManagement.MainWindowStaff   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TruckRentalManagement     5   	     � Title$  MainWindowStaff��5   	    � 
ResizeMode$ NoResize=�6!   $	��450��67   $	��630��6D   .��5	      � ���#121212$	��450��6    $��2q�6-   .+�5
   
   �� $��Person Management��6   $��10,10,425,142q�6.   
�������$��10q�6X   �� 5   
   $��Personal��6   $��216,10,220,336q�6%   
�������$��10q�6P   �� 5   
   $��Stock Management��6   $��216,115,220,56q�6-   
�������$��10q�6X   �� 5   
   $��Sales Management��6   $��421,10,16,56q�6-   
�������$��10q�6V   �� 5   
   -   5        $��logoutButton��5      $��Logout��6%   
�������$
��Left=�6I   $	��100��6d   $��50��6p   $
��Left=�6|   $��44,331,0,69q�6�    J� RenderTransformOrigin$ 0.502,1.138&�6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value �#27272763   �� 5       � �� 5      �� 5       �� 
TargetType" ��6.   .R�5   "   �� #��z��6)   ._�5   &   �� $��Center=�67   $��Center=�6T   5   #   5      5       �� Triggers 5      P� 5       P� Property �@J�IsMouseOver	 P� Value$
	 True��69   . �5      ��  � ��
 �OO/�6;   5      5!      5#      �� 5$   
   -   5        $��addNewEmployeeButton��5$      $��New Employee��6-   
�������$
��Left=�6W   $	��127��6r   $��50��6~   $��30,39,0,361q�6�   $ 	0.5,0.471&�6�   ${�False��6�   ��5%      �� 5&      " ��6   .�5'      ��  � �� �#27272763   �� 5(       � �� 5)      �� 5*      " ��6.   .R�5+   "   �� #��z��6)   ._�5,   &   �� $��Center=�67   $��Center=�6T   5-   #   5.      50       51      P� 52       �@J�IsMouseOver$
	 True��69   . �53      ��  � ��
 �OO/�6;   54      56      58      �� 5:   
   -   5        $��addNewCustomerButton��5:      $��New Customer��6-   
�������$
��Left=�6W   $	��127��6r   $��50��6~   $��31,99,0,301q�6�   $ 0.5,0.5&�6�   ��5;      �� 5<      " ��6   .�5=      ��  � �� �#27272763   �� 5>       � �� 5?      �� 5@      " ��6.   .R�5A   "   �� #��z��6)   ._�5B   &   �� $��Center=�67   $��Center=�6T   5C   #   5D      5F       5G      P� 5H       �@J�IsMouseOver$
	 True��69   . �5I      ��  � ��
 �OO/�6;   5J      5L      5N      �� 5P   
   -   5        $!��viewAndUpdateCustomerButton��5P      $��View/Update Customer��64   
�������$
��Left=�6f   $	��128��6�   $��50��6�   $��30,159,0,241q�6�   $ 	0.5,0.471&�6�   ��5Q      �� 5R      " ��6   .�5S      ��  � �� �#27272763   �� 5T       � �� 5U      �� 5V      " ��6.   .R�5W   "   �� #��z��6)   ._�5X   &   �� $��Center=�67   $��Center=�6T   5Y   #   5Z      5\       5]      P� 5^       �@J�IsMouseOver$
	 True��69   . �5_      ��  � ��
 �OO/�6;   5`      5b      5d      �� 5f   
   -   5        $!��viewAndUpdateEmployeeButton��5f      $��View/Update Employee��64   
�������$
��Left=�6f   $	��127��6�   $��50��6�   $��31,219,0,181q�6�   $ 	0.5,0.471&�6�   ${�False��6�   ��5g      �� 5h      " ��6   .�5i      ��  � �� �#27272763   �� 5j       � �� 5k      �� 5l      " ��6.   .R�5m   "   �� #��z��6)   ._�5n   &   �� $��Center=�67   $��Center=�6T   5o   #   5p      5r       5s      P� 5t       �@J�IsMouseOver$
	 True��69   . �5u      ��  � ��
 �OO/�6;   5v      5x      5z      �� 5|   
   -   5        $��viewAndUpdateInfoButton��5|      $��View/Update My Info��60   
�������$
��Left=�6a   $	��128��6|   $��50��6�   $��240,39,0,361q�6�   $ 	0.5,0.471&�6�   ��5}      �� 5~      " ��6   .�5      ��  � �� �#27272763   �� 5�       � �� 5�      �� 5�      " ��6.   .R�5�   "   �� #��z��6)   ._�5�   &   �� $��Center=�67   $��Center=�6T   5�   #   5�      5�       5�      P� 5�       �@J�IsMouseOver$
	 True��69   . �5�      ��  � ��
 �OO/�6;   5�      5�      5�      �� 5�   
   -   5        $��addNewTruckButton��5�      $��	New Truck��6*   
�������$
��Left=�6Q   $	��128��6l   $��50��6x   $��240,159,0,241q�6�   $ 	0.5,0.471&�6�   ${�False��6�   ��5�      �� 5�      " ��6   .�5�      ��  � �� �#27272763   �� 5�       � �� 5�      �� 5�      " ��6.   .R�5�   "   �� #��z��6)   ._�5�   &   �� $��Center=�67   $��Center=�6T   5�   #   5�      5�       5�      P� 5�       �@J�IsMouseOver$
	 True��69   . �5�      ��  � ��
 �OO/�6;   5�      5�      5�      �� 5�   
   -   5        $"��displayAvailableTrucksButton��5�      $��Display Available Trucks��65   
�������$
��Left=�6k   $	��128��6�   $��50��6�   $��240,204,0,146q�6�   $ 	0.5,0.471&�6�   ��5�      �� 5�      " ��6   .�5�      ��  � �� �#27272763   �� 5�       � �� 5�      �� 5�      " ��6.   .R�5�   "   �� #��z��6)   ._�5�   &   �� $��Center=�67   $��Center=�6T   5�   #   5�      5�       5�      P� 5�       �@J�IsMouseOver$
	 True��69   . �5�      ��  � ��
 �OO/�6;   5�      5�      5�      �� 5�   
   -	   5        $"��viewAndUpdateTruckInfoButton��5�      $��View/Update Truck��65   
�������$
��Left=�6d   $	��128��6   $��50��6�   $��240,301,0,99q�6�   $ 	0.5,0.471&�6�   ${�False��6�   ��5�      �� 5�      " ��6   .�5�      ��  � �� �#27272763   �� 5�       � �� 5�      �� 5�      " ��6.   .R�5�   "   �� #��z��6)   ._�5�   &   �� $��Center=�67   $��Center=�6T   5�   #   5�      5�       5�      P� 5�       �@J�IsMouseOver$
	 True��69   . �5�      ��  � ��
 �OO/�6;   5�      5�      5�      �� 5�   
   -
   5        $��rentTruckButton��5�      $��
Rent Truck��6(   
�������$
��Left=�6P   $	��128��6k   $��50��6w   $��443,39,0,361q�6�   $ 	0.5,0.471&�6�   ��5�      �� 5�      " ��6   .�5�      ��  � �� �#27272763   �� 5�       � �� 5�      �� 5�      " ��6.   .R�5�   "   �� #��z��6)   ._�5�   &   �� $��Center=�67   $��Center=�6T   5�   #   5�      5�       5�      P� 5�       �@J�IsMouseOver$
	 True��69   . �5�      ��  � ��
 �OO/�6;   5�      5�      5�      �� 5�   
   -   5        $��returnTruckButton��5�      $��Return Truck��6*   
�������$
��Left=�6T   $	��128��6o   $��50��6{   $��443,115,0,285q�6�   $ 	0.5,0.471&�6�   ��5�      �� 5�      " ��6   .�5�      ��  � �� �#27272763   �� 5�       � �� 5�      �� 5�      " ��6.   .R�5�   "   �� #��z��6)   ._�5�   &   �� $��Center=�67   $��Center=�6T   5�   #   5�      5�       5�      P� 5�       �@J�IsMouseOver$
	 True��69   . �5�      ��  � ��
 �OO/�6;   5�      5�      5�      �� 5   
   -   5        $��displayListCustomerButton��5      $��Customer Truck Search��62   
�������$
��Left=�6e   $	��128��6�   $��50��6�   $��443,169,0,181q�6�   $ 	0.5,0.471&�6�   ��5     �� 5     " ��6   .�5     ��  � �� �#27272763   �� 5      � �� 5     �� 5     " ��6.   .R�5  "   �� #��z��6)   ._�5  &   �� $��Center=�67   $��Center=�6T   5	  #   5
     5      5     P� 5      �@J�IsMouseOver$
	 True��69   . �5     ��  � ��
 �OO/�6;   5     5     5     �� 5  
   -   5        $!��displayTruckSoldsDateButton��5     $��Trucks Sold Finder��64   
�������$
��Left=�6d   $	��128��6   $��50��6�   $��443,269,0,131q�6�   $ 	0.5,0.471&�6�   ��5     �� 5     " ��6   .�5     ��  � �� �#27272763   �� 5      � �� 5     �� 5     " ��6.   .R�5  "   �� #��z��6)   ._�5  &   �� $��Center=�67   $��Center=�6T   5  #   5      5"      5#     P� 5$      �@J�IsMouseOver$
	 True��69   . �5%     ��  � ��
 �OO/�6;   5&     5(     5*     5-     5.     