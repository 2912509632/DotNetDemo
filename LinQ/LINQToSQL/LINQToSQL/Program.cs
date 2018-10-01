using System;
using System.Linq;

namespace LINQToSQL
{
    class Insert
    {
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            using (DBDataContext db = new DBDataContext())
            {
                try
                {
                    //实例化数据
                    Test data = new Test();
                    data.Name = "测试";
                    data.Sex = "男";
                    data.Time = DateTime.Now;
                    //添加数据
                    db.Test.InsertOnSubmit(data);
                    //提交更改
                    db.SubmitChanges();
                    Console.WriteLine("数据添加成功！");
                }
                catch
                {
                    Console.WriteLine("数据添加失败！");
                }
            }
        }
    }

    /// <summary>
    /// 更新数据
    /// </summary>
    class Update
    {
        static void Main(string[] args)
        {
            using (DBDataContext db = new DBDataContext())
            {
                try
                {
                    //查询张三的信息到data
                    Test data = db.Test.First(x => x.Name.Equals("张三"));
                    //修改张三的信息
                    data.Name = "张三1";
                    data.Sex = "女";
                    //提交更改
                    db.SubmitChanges();
                    Console.WriteLine("数据修改成功！");
                }
                catch
                {

                    Console.WriteLine("数据修改失败！");
                }
            }
        }
    }


    /// <summary>
    /// 删除数据
    /// </summary>
    class Delete
    {
        static void Main(string[] args)
        {
            using (DBDataContext db = new DBDataContext())
            {
                try
                {
                    //获取要删除的数据
                    Test data = db.Test.SingleOrDefault(x=>x.Name.Equals("张三1"));
                    //删除数据
                    db.Test.DeleteOnSubmit(data);
                    //提交删除
                    db.SubmitChanges();
                    Console.WriteLine("数据删除成功！");
                }
                catch
                {

                    Console.WriteLine("数据删除失败！");
                }
            }
        }
    }

}