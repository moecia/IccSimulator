# 概述
玩家将扮演处在2008年金融危机刚刚过去的ICC的老板，最终目标以发展公司至1000+人以及纳斯达克上市（年收入100万刀且公司价值7500万）。在达成最终目标后，玩家的总经营时长将会计入全球排行榜中。

基础系统，GUI可参考海岛大亨和开罗公司游戏。

## Game loop
招聘全职员工-招聘consultant-培训consultant-marketing consultant-处理consultant在client的各种突发情况（如转全职，被client炒鱿鱼等）-赚钱，研究科技，扩张公司-升级公司-招聘更多员工…

## 玩法特点/机制
- 在游戏初期，玩家可以在新泽西的几个地点成立公司并随着游戏进度可以逐渐解锁大纽约地区，新英格兰地区，美东直至全美来扩展公司业务（发掘新的client或开分公司）。
- 选择公司后，最初玩家仅占有写字楼一隅，之后随着公司人员扩张可以花钱租赁或购买更多写字楼区域。
- 在玩家雇佣第一个HR前，玩家需要手动筛选consultant候选人；在有HR后，则可以委任HR挑候选人。
- 在研究新的batch时会有5道相关技术的选择题(可跳过），玩家如果选择做题并每做对一道，研究速度增加10%（buff名：老板的指导）
- 每年通货膨胀基础值为3%

## 全局环境
- H1B申请人数
申请人数将随着经济状况的变好而变多，当经济状况中"股票指数"累计增长幅度达到500%时，员工将会需要抽签才可进行H1B申请。反之当经济降温时，则不再需要抽签。
- 绿卡排期
随着经济状况变好而时间变长，排期时长将决定"办理绿卡"这一操作所需的时间，当consultant进入绿卡等待期时，排期的增长则会降低跑率的概率。
- 经济状况


# 系统
## 公司等级
升级公司需要:
- 合同工数量达到如下
- 一半以上的合同工卖出

⭐（参考杂牌ICC）：1 - 50 <br>
⭐⭐（参考Itlize）：51 - 100 <br>
⭐⭐⭐（参考Antra）：101 - 200 <br>
⭐⭐⭐⭐（参考更大的ICC）：201 - 500 <br>
⭐⭐⭐⭐⭐（参考InfoSys)：500+ <br>

<table>
   <tr>
      <td>公司等级</td>
      <td>员工</td>
      <td>科技</td>
   </tr>
   <tr>
      <td>1</td>
      <td>Trainer: 1<br>HR: 1<br>Marketing: 2<br>Attorney: 0</td>
      <td>
        Trainer: 初级前端（JavaScript，HTML，CSS）<br>
        HR：招人研究I，医疗保险<br>
        Marketing: 卖人研究I，Evaluation，中型本地企业<br>
        Attorney: NA
      </td>
   </tr>
   <tr>
      <td>2</td>
      <td>Trainer: 3<br>HR: 3<br>Marketing: 4<br>Attorney: 1</td>
      <td>
        Trainer: 初级后端（.NET)，初级全栈（初级前端+初级后端）<br>
        HR：招人研究II，免费午餐，Stipend，Guest Housing，公司聚餐<br>
        Marketing：卖人研究II，简历欺诈，大型本地企业<br>
        Attorney:E-Verify，长期合同
      </td>
   </tr>
   <tr>
      <td>3</td>
      <td>Trainer: 6<br>HR: 5<br>Marketing: 10<br>Attorney: 2</td>
      <td>
        Trainer: 高级前端（React+Angular），高级后端(Java)，高级全栈(高前+高后）<br>
        HR：招人研究III，技能培训，401K match（fulltime）<br>
        Marketing：卖人速度III，高级背调，小型全国企业<br>
        Attorney：H1B， 绿卡，竞业条款
      </td>
   </tr>
   <tr>
      <td>4</td>
      <td>Trainer: 8<br>HR: 8<br>Marketing: 20<br>Attorney: 3</td>
      <td>
        Trainer: 初级数分（SQL）高级数分，（Python）<br>
        HR：招人研究IV， 401K match(all)<br>
        Marketing:卖人研究IV，中型全国企业，大型全国企业<br>
        Attorney:催债公司/法律传票
      </td>
   </tr>
   <tr>
      <td>5</td>
      <td>Trainer: unlimited<br>HR: unlimited<br>Marketing: unlimited<br>Attorney: unlimited</td>
      <td>
        Trainer: Data Engineer（AWS), ML Engineer, AI Engineer<br>
        HR：招人研究V，组建董事会<br>
        Marketing：卖人研究V，海外聘用，巨头公司<br>
        Attorney：合规财务报表，SEC合规性<br>
      </td>
   </tr>
</table>

## 员工
除consultant外的员工（下称全职工）玩家需手动招聘（类比主题医院等游戏的招人方式），consultant每日自动增加，其增加速率取决于HR部门人数，员工素质和相关科技加成。员工可以工作的同时产生科技点数。

玩家最初仅可招公民/绿卡consultant，此后随着移民法科技树可解锁更多种类consultant。

### 员工属性
- Fulltime：<br>
1. 毕业院校： 藤校 > 州立大学 > 社区大学
2. 工作经历：大厂 > 中厂 > 小厂
3. ICC培训程度
- Consultant:<br>
1. 美国移民状态（OPT，EAD，H1B，公民/绿卡）：移民状态越趋近永久居民抽成比例越少。（55%，40%，25%，15%）。初始可以招OPT和公民/绿卡。
2. 离职概率： 1）consultant在被卖出前和项目结束后有一定概率跑路。如果没有解锁"长期合同"科技，则在**等待新项目期间**跑路的可能性会大大增加；如果没有解锁"竞业合同"科技的话，consultant在项目结束后跑路概率会大大增加。 2）如果玩家没有解锁"E-Verify"科技，工作满一年的员工会强制离职；如果没有解锁"H1B"的话，工作3年的员工会强制离职；如果没有解锁"职业绿卡"科技的话，已有H1B的员工则会在6年后强制离职。3）如果公司没有解锁"劳动法"所有科技的话，员工离职概率将有一个逐年提成的debuff。
3. 工作年限（TODO）：决定项目总价的上限

   
### 员工类型
- Trainer:培训consultant，trainer整体素质越高培训所需天数越少，提供科技点数以解锁新的培训Batch。
- HR:负责招聘consultant，**基础速率每人每天招入一名合同工**。素质越高每日招聘人数越多，提供科技点数解锁员工福利。
- Marketing：负责将consultant卖给client，**基础速率每人每五天卖出一名合同工**。素质越高每日卖人越多，提供点数解锁新client。
- Attorney：防止consultant跳槽或跑路，**基础阻止跑路的效率每人降低3%，上限降低15**。提供点数解锁移民法、劳动法。
- Consultant：在没有任何科技研究的情况下，未上项目每天跑路的概率为40%，项目完成时跑路概率为50%。

## 科技树
### Trainer
Web开发（培训基数天为60）：初级前端（初始） – 初级后端 – 初级全栈 – 高级前端 … - 高级全栈

数据科学（培训技术天为90）：初级数分 - … – 高级数分 – Data Engineer - ML Engineer – AI Engineer

### HR
招人速度研究（%递增）：电话（5） – 报纸（10） – 校园招聘（15） – 找工网站（20） – 找工app （30）

员工福利：
- 医疗保险：每月的支出换效率，可以调整公司的converge，但承担额度不能小于50%。
- Stipend: 每月支出换等待卖出员工跑路几率的降低
- Guest housing: 解锁"员工宿舍"的购买或租赁，宿舍可以收费或者免费租给consultant，降低等待卖出员工的跑路概率,
- 免费午餐：每月支出换效率
- 公司聚餐：单次使用，每次提升3个月员工效率，可以具体设计聚餐类型如happy hour， summer party等使得更符合美国真实情况
- 技能培训：单次使用，增加全员工作能力
- 401k match(fulltime/all)：效果同医疗保险，但员工工资越高对应支出越高

### Marketing
卖人研究（提升卖人速率，允许batch卖人等）：
Evaluation：解锁"自定义合同"合同中的周期性的培训考核，通过减低学员存活率获取更高的marketing速度
简历欺诈 - 面试作弊：获取更高的marketing速度
高级背调 - 项目指导：降低上项目后被解雇的概率
海外聘用：解锁"海外招聘"，激活后每月花费一定金额获取海外员工的缓慢增加。海外招聘的员工因h1b限制和不平等条约，5年内不会跑路

Client（consultant每半月盈利提升，可以给企业一个耳熟能详的名称）：小型本地企业 -中型本地企业 – 大型本地企业 – 小型全国企业 … -大型全国企业 – 巨头

### Attorney
劳动法：
长期合同：解锁"自定义合同"中的"劳务时长"以及"违约金"。其两项数值越高则员工拒付的可能性越高。此外降低大大降低员工在**上项目前**/**等待新项目**的跑路概率。
催债公司 - 法律传票：降低员工跑路拒付违约金的概率。
竞业合同：解锁"自定义合同"的"竞业条款违约金"，此外降低员工在项目结束后的跑路概率。

移民法：
- E-Verify：解锁H1B研究，OPT工作年限可延长至3年，解锁EAD员工招聘
- H1B：解锁职业绿卡研究，可以给OPT员工抽签或办理H1B，办理H1B中的员工一年内无法离职，在此之后H1B员工，解锁H1B员工招聘
- 绿卡：可以给员工办理绿卡，办理绿卡的员工2年内（1年为基础时常，该时间会随着"全局环境-绿卡排期"的恶化而变长）无法离职且大大降低其跑路概率

### 上市科技
- HR：组建董事会
- Attorney：合规财务报表，SEC合规性

# 数值设定
<table>
   <tr>
      <td>名称</td>
      <td>基础数值</td>
      <td>影响因素</td>
   </tr>
   <tr>
      <td>跑路概率</td>
      <td>等待项目期间：50%每天；项目结束：50%</td>
      <td>
         律师：每个律师-3%，最大-15%<br>
         H1B办理期间：1年内，0%
         绿卡办理期间：1年或更多，0%
         竞业合同：-5%
         Stipend：-（stpend/1000）%
         
      </td>
   </tr>
   <tr>
      <td>拒付违约金概率</td>
      <td>基础数值</td>
      <td>影响因素</td>
   </tr>
   <tr>
      <td>解雇概率</td>
      <td>基础数值</td>
      <td>影响因素</td>
   </tr>
   <tr>
      <td>招人速率</td>
      <td>基础数值</td>
      <td>影响因素</td>
   </tr>
   <tr>
      <td>培训天数</td>
      <td>基础数值</td>
      <td>影响因素</td>
   </tr>
   <tr>
      <td>卖人一次性收入</td>
      <td>基础数值</td>
      <td>影响因素</td>
   </tr>
   <tr>
      <td>项目TC</td>
      <td>基础数值</td>
      <td>影响因素</td>
   </tr>
</table>
# 劳动合同




