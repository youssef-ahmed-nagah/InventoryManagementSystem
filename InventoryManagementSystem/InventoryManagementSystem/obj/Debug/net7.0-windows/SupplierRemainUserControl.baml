   M S B A M L   `   `   `  ����T  PInventoryManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:InventoryManagementSystemInventoryManagementSystem  5      9    3InventoryManagementSystem.SupplierRemainUserControl   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:InventoryManagementSystem     5      .��5
      �   � ShowGridLines$  False��6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��70 �6   �� 5      $	��150 �6   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � $��0��6    � Orientation$ 
Horizontal=�6!   .+�5      �� $��0,0,0,1q�6   
�������$��5q�6C   ._�5      �� $��50��6   $��
50,20,30,0q�6)   .+�5      �� $��2q�6   $
��Left=�6(   
�������.��6V   Supplier Name6e   �� 5      -   5        $��txtSearchForSupplierName��5   *   $	��200��6   6L   5      5      5      � 5!   
   $��1��6   $	��100��6!   $��225,0,225,0q�6-   .+�5"      �� -   5        $��btnSearchForSupplier��5"      $	��100��61   $��30��6=   
�������
��� � �$��2q�6p   
��� � �$��	5,20,10,0q�6�   .��6�   Select6�   5#      � 5%   
   $��2��6   .+�5'      �� -   5        $��lvSearchForSupplier��5'   0   $	��800��6   $	��150��6#    �� SelectionMode$ Single=�6K    �� View 5)      �� 5+       �� AllowsColumnReorder$
 true��6    �� ColumnHeaderToolTip$ Supplier Information��6:   .P�5-      ��  �� Width$	 400��6)    �� DisplayMemberBinding 65   �� *Name+.��5.      �� .��63   Name50      51      �� 53      $	 400��6)    65   �� *Remain+.��54      �� .��64   Remain56      57      59      5<      5>      � 5@   
   $��3��6   $	��200��6!   $��Center=�6-   .+�5A      �� 
�������Name:64   �� 5B      -   5        $&�� txtSearchForSupplierSelectedName��5B      $��0,0,30,0q�6@   
�������6g   �� 5D      
�������	Remain:64   �� 5E      -   5        $(��"txtSearchForSupplierSelectedRemain��5E      $��0,0,30,0q�6B   
�������6i   5F      � 5H   
   $��4��6   $	��250��6!   $��
50 20 50 0q�6-   .+�5J      �� -   5        $��txtSearchForSupplierPaied��5J      $	��100��67   $��30��6C   6R   �� 5K      -   5        $!��btnSearchForSupplierConfirm��5K      $	��100��68   $��30��6D   
�������
��� � �$��2q�6w   
��� � �$��5,0,10,0q�6�   .��6�   Pay6�   5M      5O      5P      