using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SectionStatus : IMessage<SectionStatus>, IMessage, IEquatable<SectionStatus>, IDeepCloneable<SectionStatus>, IBufferMessage
{
	private static readonly MessageParser<SectionStatus> _parser = new MessageParser<SectionStatus>(() => new SectionStatus());

	private UnknownFieldSet _unknownFields;

	public const int SectionIdFieldNumber = 4;

	private uint sectionId_;

	public const int SectionStatus_FieldNumber = 11;

	private MessageSectionStatus sectionStatus_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SectionStatus> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SectionStatusReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SectionId
	{
		get
		{
			return sectionId_;
		}
		set
		{
			sectionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageSectionStatus SectionStatus_
	{
		get
		{
			return sectionStatus_;
		}
		set
		{
			sectionStatus_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SectionStatus()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SectionStatus(SectionStatus other)
		: this()
	{
		sectionId_ = other.sectionId_;
		sectionStatus_ = other.sectionStatus_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SectionStatus Clone()
	{
		return new SectionStatus(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SectionStatus);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SectionStatus other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SectionId != other.SectionId)
		{
			return false;
		}
		if (SectionStatus_ != other.SectionStatus_)
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
		if (SectionId != 0)
		{
			num ^= SectionId.GetHashCode();
		}
		if (SectionStatus_ != MessageSectionStatus.MessageSectionNone)
		{
			num ^= SectionStatus_.GetHashCode();
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
		if (SectionId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(SectionId);
		}
		if (SectionStatus_ != MessageSectionStatus.MessageSectionNone)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)SectionStatus_);
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
		if (SectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SectionId);
		}
		if (SectionStatus_ != MessageSectionStatus.MessageSectionNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SectionStatus_);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SectionStatus other)
	{
		if (other != null)
		{
			if (other.SectionId != 0)
			{
				SectionId = other.SectionId;
			}
			if (other.SectionStatus_ != MessageSectionStatus.MessageSectionNone)
			{
				SectionStatus_ = other.SectionStatus_;
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
				SectionId = input.ReadUInt32();
				break;
			case 88u:
				SectionStatus_ = (MessageSectionStatus)input.ReadEnum();
				break;
			}
		}
	}
}
