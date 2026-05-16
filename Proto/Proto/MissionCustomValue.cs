using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MissionCustomValue : IMessage<MissionCustomValue>, IMessage, IEquatable<MissionCustomValue>, IDeepCloneable<MissionCustomValue>, IBufferMessage
{
	private static readonly MessageParser<MissionCustomValue> _parser = new MessageParser<MissionCustomValue>(() => new MissionCustomValue());

	private UnknownFieldSet _unknownFields;

	public const int CustomValueFieldNumber = 4;

	private uint customValue_;

	public const int DLCLDIAOIMKFieldNumber = 14;

	private string dLCLDIAOIMK_ = "";

	public const int IndexFieldNumber = 15;

	private uint index_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MissionCustomValue> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MissionCustomValueReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CustomValue
	{
		get
		{
			return customValue_;
		}
		set
		{
			customValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DLCLDIAOIMK
	{
		get
		{
			return dLCLDIAOIMK_;
		}
		set
		{
			dLCLDIAOIMK_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionCustomValue()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionCustomValue(MissionCustomValue other)
		: this()
	{
		customValue_ = other.customValue_;
		dLCLDIAOIMK_ = other.dLCLDIAOIMK_;
		index_ = other.index_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionCustomValue Clone()
	{
		return new MissionCustomValue(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MissionCustomValue);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MissionCustomValue other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CustomValue != other.CustomValue)
		{
			return false;
		}
		if (DLCLDIAOIMK != other.DLCLDIAOIMK)
		{
			return false;
		}
		if (Index != other.Index)
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
		if (CustomValue != 0)
		{
			num ^= CustomValue.GetHashCode();
		}
		if (DLCLDIAOIMK.Length != 0)
		{
			num ^= DLCLDIAOIMK.GetHashCode();
		}
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
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
		if (CustomValue != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CustomValue);
		}
		if (DLCLDIAOIMK.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(DLCLDIAOIMK);
		}
		if (Index != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Index);
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
		if (CustomValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CustomValue);
		}
		if (DLCLDIAOIMK.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DLCLDIAOIMK);
		}
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MissionCustomValue other)
	{
		if (other != null)
		{
			if (other.CustomValue != 0)
			{
				CustomValue = other.CustomValue;
			}
			if (other.DLCLDIAOIMK.Length != 0)
			{
				DLCLDIAOIMK = other.DLCLDIAOIMK;
			}
			if (other.Index != 0)
			{
				Index = other.Index;
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
			case 32u:
				CustomValue = input.ReadUInt32();
				break;
			case 114u:
				DLCLDIAOIMK = input.ReadString();
				break;
			case 120u:
				Index = input.ReadUInt32();
				break;
			}
		}
	}
}
