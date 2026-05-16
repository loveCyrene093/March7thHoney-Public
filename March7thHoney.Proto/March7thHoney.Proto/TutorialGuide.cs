using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TutorialGuide : IMessage<TutorialGuide>, IMessage, IEquatable<TutorialGuide>, IDeepCloneable<TutorialGuide>, IBufferMessage
{
	private static readonly MessageParser<TutorialGuide> _parser = new MessageParser<TutorialGuide>(() => new TutorialGuide());

	private UnknownFieldSet _unknownFields;

	public const int StatusFieldNumber = 9;

	private TutorialStatus status_;

	public const int TypeFieldNumber = 12;

	private TutorialGuideType type_;

	public const int IdFieldNumber = 13;

	private uint id_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TutorialGuide> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TutorialGuideReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TutorialStatus Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TutorialGuideType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TutorialGuide()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TutorialGuide(TutorialGuide other)
		: this()
	{
		status_ = other.status_;
		type_ = other.type_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TutorialGuide Clone()
	{
		return new TutorialGuide(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TutorialGuide);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TutorialGuide other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Id != other.Id)
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
		if (Status != TutorialStatus.TutorialNone)
		{
			num ^= Status.GetHashCode();
		}
		if (Type != TutorialGuideType.FgklpmcjbacNnmbahcckja)
		{
			num ^= Type.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
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
		if (Status != TutorialStatus.TutorialNone)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)Status);
		}
		if (Type != TutorialGuideType.FgklpmcjbacNnmbahcckja)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)Type);
		}
		if (Id != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Id);
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
		if (Status != TutorialStatus.TutorialNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (Type != TutorialGuideType.FgklpmcjbacNnmbahcckja)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TutorialGuide other)
	{
		if (other != null)
		{
			if (other.Status != TutorialStatus.TutorialNone)
			{
				Status = other.Status;
			}
			if (other.Type != TutorialGuideType.FgklpmcjbacNnmbahcckja)
			{
				Type = other.Type;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
			case 72u:
				Status = (TutorialStatus)input.ReadEnum();
				break;
			case 96u:
				Type = (TutorialGuideType)input.ReadEnum();
				break;
			case 104u:
				Id = input.ReadUInt32();
				break;
			}
		}
	}
}
