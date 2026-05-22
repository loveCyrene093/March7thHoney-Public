using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RotaterEnergyInfo : IMessage<RotaterEnergyInfo>, IMessage, IEquatable<RotaterEnergyInfo>, IDeepCloneable<RotaterEnergyInfo>, IBufferMessage
{
	private static readonly MessageParser<RotaterEnergyInfo> _parser = new MessageParser<RotaterEnergyInfo>(() => new RotaterEnergyInfo());

	private UnknownFieldSet _unknownFields;

	public const int CurNumFieldNumber = 1;

	private uint curNum_;

	public const int MaxNumFieldNumber = 3;

	private uint maxNum_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RotaterEnergyInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RotaterEnergyInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurNum
	{
		get
		{
			return curNum_;
		}
		set
		{
			curNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxNum
	{
		get
		{
			return maxNum_;
		}
		set
		{
			maxNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotaterEnergyInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotaterEnergyInfo(RotaterEnergyInfo other)
		: this()
	{
		curNum_ = other.curNum_;
		maxNum_ = other.maxNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotaterEnergyInfo Clone()
	{
		return new RotaterEnergyInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RotaterEnergyInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RotaterEnergyInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CurNum != other.CurNum)
		{
			return false;
		}
		if (MaxNum != other.MaxNum)
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
		if (CurNum != 0)
		{
			num ^= CurNum.GetHashCode();
		}
		if (MaxNum != 0)
		{
			num ^= MaxNum.GetHashCode();
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
		if (CurNum != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CurNum);
		}
		if (MaxNum != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MaxNum);
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
		if (CurNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurNum);
		}
		if (MaxNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RotaterEnergyInfo other)
	{
		if (other != null)
		{
			if (other.CurNum != 0)
			{
				CurNum = other.CurNum;
			}
			if (other.MaxNum != 0)
			{
				MaxNum = other.MaxNum;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 8u:
				CurNum = input.ReadUInt32();
				break;
			case 24u:
				MaxNum = input.ReadUInt32();
				break;
			}
		}
	}
}
