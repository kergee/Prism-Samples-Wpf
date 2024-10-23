# Prism WPF示例，基于.NET6和Prism9

这些示例展示了如何在 WPF 中使用各种 Prism 功能。如果您刚开始学习 Prism，建议您从第一个示例开始，按顺序依次学习列表中的内容。每个示例都基于前一个示例的概念。

Topic | 描述 
-----------|-------------
[Bootstrapper and the Shell][1] | 创建一个基本的引导程序和外壳 
[Regions][2] | 创建一个区域 
[Custom Region Adapter][3] | 为 StackPanel 创建一个自定义区域适配器 
[View Discovery][4] | 使用视图发现自动注入视图 
[View Injection][5] | 使用视图注入手动添加和移除视图 
[View Activation/Deactivation][6] | 手动激活和停用视图 
[Modules with App.config][7] | 使用 App.config 文件加载模块 
[Modules with Code][8] | 使用代码加载模块 
[Modules with Directory][9] | 从目录加载模块 
[Modules loaded manually][10] | 使用 IModuleManager 手动加载模块 
[ViewModelLocator][11] | 使用 ViewModelLocator 
[ViewModelLocator - Change Convention][12] | 更改 ViewModelLocator 的命名约定 
[ViewModelLocator - Custom Registrations][13] | 为特定视图手动注册 ViewModel 
[DelegateCommand][14] | 使用 DelegateCommand 和 `DelegateCommand<T>` 
[CompositeCommands][15] | 学习如何使用 CompositeCommands 将多个命令作为单个命令调用 
[IActiveAware Commands][16] | 使您的命令实现 IActiveAware 以仅调用活动命令 
[Event Aggregator][17] | 使用 IEventAggregator 
[Event Aggregator - Filter Events][18] | 在订阅事件时过滤事件 
[RegionContext][19] | 使用 RegionContext 向嵌套区域传递数据 
[Region Navigation][20] | 了解如何实现基本的区域导航 
[Navigation Callback][21] | 在导航完成时获取通知 
[Navigation Participation][22] | 了解视图和 ViewModel 如何通过 INavigationAware 参与导航 
[Navigate to existing Views][23] | 在导航期间控制视图实例 
[Passing Parameters][24] | 从视图/ViewModel 向另一个视图/ViewModel 传递参数 
[Confirm/cancel Navigation][25] | 使用 IConfirmNavigationReqest 接口来确认或取消导航 
[Controlling View lifetime][26] | 使用 IRegionMemberLifetime 自动从内存中移除视图 
[Navigation Journal][27] | 学习如何使用导航日志 
[Dialog Service][29] | 学习如何使用对话框服务
[Styling Dialog][30] | 学习如何设置对话框样式
[Using Custom Window][31] | 学习如何使用自定义窗口
[Interactivity - InvokeCommandAction][32] | 响应任何事件调用命令 

[1]: 01-BootstrapperShell/
[2]: 02-Regions/
[3]: 03-CustomRegions/
[4]: 04-ViewDiscovery/
[5]: 05-ViewInjection/
[6]: 06-ViewActivationDeactivation/
[7]: 07-Modules-AppConfig/
[8]: 07-Modules-Code/
[9]: 07-Modules-Directory/
[10]: 07-Modules-LoadManual/
[11]: 08-ViewModelLocator/
[12]: 09-ChangeConvention/
[13]: 10-CustomRegistrations/
[14]: 11-UsingDelegateCommands/
[15]: 12-UsingCompositeCommands/
[16]: 13-IActiveAwareCommands/
[17]: 14-UsingEventAggregator/
[18]: 15-FilteringEvents/
[19]: 16-RegionContext/
[20]: 17-BasicRegionNavigation/
[21]: 18-NavigationCallback/
[22]: 19-NavigationParticipation/
[23]: 20-NavigateToExistingViews/
[24]: 21-PassingParameters/
[25]: 22-ConfirmCancelNavigation/
[26]: 23-RegionMemberLifetime/
[27]: 24-NavigationJournal/
[29]: 26-UsingDialogService/
[30]: 27-StylingDialog/
[31]: 28-UsingCustomWindow/
[32]: 29-InvokeCommandAction/

其他入门教程：
- https://elf-mission.net/wpf-prism-index/
- https://wpf-tutorial.com/Localization/LanguageStatus/zh/
