using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MainMissionCustomValue : IMessage<MainMissionCustomValue>, IMessage, IEquatable<MainMissionCustomValue>, IDeepCloneable<MainMissionCustomValue>, IBufferMessage
{
	private static readonly MessageParser<MainMissionCustomValue> _parser = new MessageParser<MainMissionCustomValue>(() => new MainMissionCustomValue());

	private UnknownFieldSet _unknownFields;

	public const int CustomValueListFieldNumber = 5;

	private EPNCDFBAHEA customValueList_;

	public const int MainMissionIdFieldNumber = 11;

	private uint mainMissionId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MainMissionCustomValue> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MainMissionCustomValueReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPNCDFBAHEA CustomValueList
	{
		get
		{
			return customValueList_;
		}
		set
		{
			customValueList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MainMissionId
	{
		get
		{
			return mainMissionId_;
		}
		set
		{
			mainMissionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MainMissionCustomValue()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MainMissionCustomValue(MainMissionCustomValue other)
		: this()
	{
		customValueList_ = ((other.customValueList_ != null) ? other.customValueList_.Clone() : null);
		mainMissionId_ = other.mainMissionId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MainMissionCustomValue Clone()
	{
		return new MainMissionCustomValue(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MainMissionCustomValue);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MainMissionCustomValue other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CustomValueList, other.CustomValueList))
		{
			return false;
		}
		if (MainMissionId != other.MainMissionId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (customValueList_ != null)
		{
			num ^= CustomValueList.GetHashCode();
		}
		if (MainMissionId != 0)
		{
			num ^= MainMissionId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (customValueList_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(CustomValueList);
		}
		if (MainMissionId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(MainMissionId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (customValueList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CustomValueList);
		}
		if (MainMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MainMissionId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MainMissionCustomValue other)
	{
		if (other == null)
		{
			return;
		}
		if (other.customValueList_ != null)
		{
			if (customValueList_ == null)
			{
				CustomValueList = new EPNCDFBAHEA();
			}
			CustomValueList.MergeFrom(other.CustomValueList);
		}
		if (other.MainMissionId != 0)
		{
			MainMissionId = other.MainMissionId;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 42u:
				if (customValueList_ == null)
				{
					CustomValueList = new EPNCDFBAHEA();
				}
				input.ReadMessage(CustomValueList);
				break;
			case 88u:
				MainMissionId = input.ReadUInt32();
				break;
			}
		}
	}
}
