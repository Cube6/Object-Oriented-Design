using Design_Patterns.Structural.Adapter.Structuralcode;

namespace Design_Patterns.Structural.Adapter
{
	/*
     * Motivation:
     *      The adapter pattern is adapting between classes and objects. Like any adapter in the real world it is used to be an interface, a bridge between two objects. 
     *  In real world we have adapters for power supplies, adapters for camera memory cards, and so on. Probably everyone have seen some adapters for memory cards. 
     *  If you can not plug in the camera memory in your laptop you can use and adapter. You plug the camera memory in the adapter and the adapter in to laptop slot. That's it, it's really simple.
     *      What about software development? It's the same. 
     *  Can you imagine an situation when you have some class expecting some type of object and you have an object offering the same features, but exposing a different interface? 
     *  Of course, you want to use both of them so you don't to implement again one of them, and you don't want to change existing classes, so why not create an adapter...
     * 
     *      适配器模式在类和对象之间进行调整。像现实世界中的任何适配器一样，它被用作接口，两个对象之间的桥梁。
     *  在现实世界中，我们有电源适配器，相机存储卡适配器，等等。可能每个人都见过一些存储卡适配器。
     *  如果你不能在你的笔记本电脑中插入相机内存，你可以使用和适配器。将相机内存插入适配器，将适配器插入笔记本电脑插槽。就这样，真的很简单。
     *      软件开发呢？是一样的。你能想象这样一种情况吗？当某个类需要某种类型的对象，而某个对象提供了相同的特性，但却公开了不同的接口？
     *  当然，您希望同时使用这两个类，这样就不需要再次实现其中一个，也不需要更改现有的类，所以为什么不创建一个适配器。。。
     *  
     * Intent:
     *      Convert the interface of a class into another interface clients expect.
     *      Adapter lets classes work together, that could not otherwise because of incompatible interfaces.
     *      将一个类的接口转换为客户机期望的另一个接口。
     *      适配器允许类一起工作，否则由于接口不兼容而无法工作。
     */
	public class AdapterStructuralDemo : PatternDemoBase
	{
		public override string PatternName => "Adapter (Structured)";

		protected override void RunImpl()
		{
			Target target = new Structuralcode.Adapter();
			target.Request();

		}
	}
}
