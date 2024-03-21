# 概述
玩家将扮演处在2008年金融危机刚刚过去的ICC的老板，最终目标以发展公司至1000+人以及纳斯达克上市。

基础系统，GUI可参考海岛大亨和开罗公司游戏。

### Game loop
招聘全职员工-招聘consultant-培训consultant-marketing consultant-处理consultant在client的各种突发情况（如转全职，被client炒鱿鱼等）-赚钱，研究科技-升级公司-招聘更多员工…

# 系统
## 公司等级
等级从1到5。公司等级由如下数值决定
Consultant人数（具体数值见下）

⭐（参考杂牌ICC）：0 - 50 <br>
⭐⭐（参考Itlize）：51 - 200 <br>
⭐⭐⭐（参考Antra）：201 - 500 <br>
⭐⭐⭐⭐（参考更大的ICC）：501 - 1000 <br>
⭐⭐⭐⭐⭐（参考InfoSys)：1000+ <br>

## 员工
除consultant外的员工（下称全职工）玩家需手动招聘（类比主题医院等游戏的招人方式），consultant每日自动增加，其增加速率取决于HR部门人数，员工素质和相关科技加成。员工可以工作的同时产生科技点数。

玩家最初仅可招公民/绿卡consultant，此后随着移民法科技树可解锁更多种类consultant。

### 员工属性
- 全职工：<br>
1. 毕业院校： 藤校 > 州立大学 > 社区大学
2. 工作经历：大厂 > 中厂 > 小厂
3. ICC培训程度
- Consultant:<br>
1. 美国移民状态（OPT，EAD，H1B，公民/绿卡），移民状态越趋近永久居民抽成比例越多。（55%，40%，25%，15%）
2. 跑路概率：合同工当
   
### 员工类型
- Trainer:培训consultant，trainer整体素质越高培训所需天数越少，提供科技点数以解锁新的培训Batch。
- HR: 负责招聘consultant，素质越高每日招聘人数越多，提供科技点数解锁员工福利。
- Marketing：负责将consultant卖给client，素质越高每日卖人越多，提供点数解锁新client。
- Attorney：防止consultant跳槽或跑路，提供点数解锁移民法、劳动法。
- Consultant

## 科技树
### Trainer
Web开发（培训基数天为60）：初级前端（初始） – 初级后端 – 初级全栈 – 中级后端 … - 高级全栈

数据科学（培训技术天为90）：初级数分 - … – 高级数分 – Data Engineer - MLP – AI

### HR
招人速度研究（%递增）：街头广告（0）-  电话（5） – 报纸（10） – 校园招聘（15） – 找工网站（20） – 找工app （30）

员工福利：
- 医疗保险（每月的支出换效率，可以调整公司的converge）
- 免费午餐（每月支出换效率）
- 公司聚餐（单次使用，每次提升3个月员工效率，可以具体设计聚餐类型如happy hour， summer party等使得更符合美国真实情况）
- 401k match（效果同医疗保险，但员工工资越高对应支出越高）

### Marketing
卖人研究（提升卖人速率，允许batch卖人等）：
- Evaluation(解锁周期性的培训考核，通过减低学员存活率获取更高的marketing速度

Client（consultant每半月盈利提升，可以给企业一个耳熟能详的名称）：小型本地企业 -中型本地企业 – 中型本地企业 – 小型全国企业 … -大型全国企业 – 巨头

### Attorney
劳动法：

移民法：
- E-Verify(解锁H1B研究，OPT工作年限可延长至3年），

# 劳动合同




