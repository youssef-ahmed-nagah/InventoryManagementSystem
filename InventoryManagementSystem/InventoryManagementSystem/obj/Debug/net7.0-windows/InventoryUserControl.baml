   M S B A M L   `   `   `  ����T  PInventoryManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:InventoryManagementSystemInventoryManagementSystem  5      4    .InventoryManagementSystem.InventoryUserControl   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:InventoryManagementSystem     5      .��5	      �   � ShowGridLines$  False��6    � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��Stretch=�6!    � Orientation$ 
Horizontal=�6?   .+�5      �� $��0,0,0,1q�6   
�������$��5q�6C   ._�5      �� $��50��6   $��
20,20,30,0q�6)   .+�5      �� $��2q�6   $
��Left=�6(   
�������.��6V   Inventory Name6f   �� 5      -   5        $��InventoryNameTxtBx��5   *   $	��200��6   ��6D   ��  �� ElementName$ InventoryListView�� �� Path$ SelectedItem.Location� �� Mode$ OneWay=�6�   5      5      5      � 5   
   $��1��6   $	��350��6!   .+�5      �� -   5        $��AddNewInventory��5      $	��100��6,   $��30��68   
�������
��� � �$��2q�6k   
��� � �$��	5,20,10,0q�6�   .��6�   New6�   �� 5       -   5        $��EditInventory��5       $	��100��6*   $��30��66   
�������
����  �$��2q�6h   
����  �$��	5,20,10,0q�6�   .��6�   Save6�   �� 5!      -   5        $��DeleteInventory��5!      $	��100��6,   $��30��68   
�������
���  ��$��2q�6i   
���  ��$��5,20,5,0q�6�   .��6�   Delete6�   5"      � 5$   
   $��2��6   .+�5'      �� -   5        $��InventoryListView��5'   0   $	��800��6   $	��150��6#    �� SelectionMode$ Single=�6I    �� View 5)      �� 5+       �� AllowsColumnReorder$
 true��6   	 �� ColumnHeaderToolTip$	 Product Information��6:   .P�5-      �� -   5        ID��
 �� Width$	
 100��5-   5    �� DisplayMemberBinding 6A   �� *ID+.��5.      �� .��63   Number50      51      �� 53      $	
 700��6)    65   �� *
Location+.��54      �� $
��Left=�63   .��6N   	Inventory56      57      59      5<      5>      5?      5@      