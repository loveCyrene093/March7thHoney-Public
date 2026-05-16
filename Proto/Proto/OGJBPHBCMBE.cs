using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OGJBPHBCMBE : IMessage<OGJBPHBCMBE>, IMessage, IEquatable<OGJBPHBCMBE>, IDeepCloneable<OGJBPHBCMBE>, IBufferMessage
{
	private static readonly MessageParser<OGJBPHBCMBE> _parser = new MessageParser<OGJBPHBCMBE>(() => new OGJBPHBCMBE());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 3;

	private uint groupId_;

	public const int JEFKCIMHCCOFieldNumber = 9;

	private static readonly FieldCodec<KAAEBONPKEP> _repeated_jEFKCIMHCCO_codec = FieldCodec.ForMessage(74u, KAAEBONPKEP.Parser);

	private readonly RepeatedField<KAAEBONPKEP> jEFKCIMHCCO_ = new RepeatedField<KAAEBONPKEP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OGJBPHBCMBE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OGJBPHBCMBEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<KAAEBONPKEP> JEFKCIMHCCO => jEFKCIMHCCO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGJBPHBCMBE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGJBPHBCMBE(OGJBPHBCMBE other)
		: this()
	{
		groupId_ = other.groupId_;
		jEFKCIMHCCO_ = other.jEFKCIMHCCO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGJBPHBCMBE Clone()
	{
		return new OGJBPHBCMBE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OGJBPHBCMBE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OGJBPHBCMBE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (!jEFKCIMHCCO_.Equals(other.jEFKCIMHCCO_))
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		num ^= jEFKCIMHCCO_.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GroupId);
		}
		jEFKCIMHCCO_.WriteTo(ref output, _repeated_jEFKCIMHCCO_codec);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		num += jEFKCIMHCCO_.CalculateSize(_repeated_jEFKCIMHCCO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OGJBPHBCMBE other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			jEFKCIMHCCO_.Add(other.jEFKCIMHCCO_);
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
				GroupId = input.ReadUInt32();
				break;
			case 74u:
				jEFKCIMHCCO_.AddEntriesFrom(ref input, _repeated_jEFKCIMHCCO_codec);
				break;
			}
		}
	}
}
