using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JKLFBDFJLJH : IMessage<JKLFBDFJLJH>, IMessage, IEquatable<JKLFBDFJLJH>, IDeepCloneable<JKLFBDFJLJH>, IBufferMessage
{
	private static readonly MessageParser<JKLFBDFJLJH> _parser = new MessageParser<JKLFBDFJLJH>(() => new JKLFBDFJLJH());

	private UnknownFieldSet _unknownFields;

	public const int IsFinishFieldNumber = 5;

	private bool isFinish_;

	public const int EGEFHCFJICCFieldNumber = 8;

	private uint eGEFHCFJICC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JKLFBDFJLJH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JKLFBDFJLJHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsFinish
	{
		get
		{
			return isFinish_;
		}
		set
		{
			isFinish_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EGEFHCFJICC
	{
		get
		{
			return eGEFHCFJICC_;
		}
		set
		{
			eGEFHCFJICC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKLFBDFJLJH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKLFBDFJLJH(JKLFBDFJLJH other)
		: this()
	{
		isFinish_ = other.isFinish_;
		eGEFHCFJICC_ = other.eGEFHCFJICC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKLFBDFJLJH Clone()
	{
		return new JKLFBDFJLJH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JKLFBDFJLJH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JKLFBDFJLJH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsFinish != other.IsFinish)
		{
			return false;
		}
		if (EGEFHCFJICC != other.EGEFHCFJICC)
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
		if (IsFinish)
		{
			num ^= IsFinish.GetHashCode();
		}
		if (EGEFHCFJICC != 0)
		{
			num ^= EGEFHCFJICC.GetHashCode();
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
		if (IsFinish)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsFinish);
		}
		if (EGEFHCFJICC != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EGEFHCFJICC);
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
		if (IsFinish)
		{
			num += 2;
		}
		if (EGEFHCFJICC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EGEFHCFJICC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JKLFBDFJLJH other)
	{
		if (other != null)
		{
			if (other.IsFinish)
			{
				IsFinish = other.IsFinish;
			}
			if (other.EGEFHCFJICC != 0)
			{
				EGEFHCFJICC = other.EGEFHCFJICC;
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
			case 40u:
				IsFinish = input.ReadBool();
				break;
			case 64u:
				EGEFHCFJICC = input.ReadUInt32();
				break;
			}
		}
	}
}
