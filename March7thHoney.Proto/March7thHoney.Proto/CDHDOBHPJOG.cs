using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CDHDOBHPJOG : IMessage<CDHDOBHPJOG>, IMessage, IEquatable<CDHDOBHPJOG>, IDeepCloneable<CDHDOBHPJOG>, IBufferMessage
{
	private static readonly MessageParser<CDHDOBHPJOG> _parser = new MessageParser<CDHDOBHPJOG>(() => new CDHDOBHPJOG());

	private UnknownFieldSet _unknownFields;

	public const int COOOFFKIDMCFieldNumber = 3;

	private uint cOOOFFKIDMC_;

	public const int GroupIdFieldNumber = 14;

	private uint groupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CDHDOBHPJOG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CDHDOBHPJOGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint COOOFFKIDMC
	{
		get
		{
			return cOOOFFKIDMC_;
		}
		set
		{
			cOOOFFKIDMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDHDOBHPJOG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDHDOBHPJOG(CDHDOBHPJOG other)
		: this()
	{
		cOOOFFKIDMC_ = other.cOOOFFKIDMC_;
		groupId_ = other.groupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDHDOBHPJOG Clone()
	{
		return new CDHDOBHPJOG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CDHDOBHPJOG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CDHDOBHPJOG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (COOOFFKIDMC != other.COOOFFKIDMC)
		{
			return false;
		}
		if (GroupId != other.GroupId)
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
		if (COOOFFKIDMC != 0)
		{
			num ^= COOOFFKIDMC.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
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
		if (COOOFFKIDMC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(COOOFFKIDMC);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GroupId);
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
		if (COOOFFKIDMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(COOOFFKIDMC);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CDHDOBHPJOG other)
	{
		if (other != null)
		{
			if (other.COOOFFKIDMC != 0)
			{
				COOOFFKIDMC = other.COOOFFKIDMC;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
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
			case 24u:
				COOOFFKIDMC = input.ReadUInt32();
				break;
			case 112u:
				GroupId = input.ReadUInt32();
				break;
			}
		}
	}
}
