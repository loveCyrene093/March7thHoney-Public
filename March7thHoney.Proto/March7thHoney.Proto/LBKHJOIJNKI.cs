using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LBKHJOIJNKI : IMessage<LBKHJOIJNKI>, IMessage, IEquatable<LBKHJOIJNKI>, IDeepCloneable<LBKHJOIJNKI>, IBufferMessage
{
	private static readonly MessageParser<LBKHJOIJNKI> _parser = new MessageParser<LBKHJOIJNKI>(() => new LBKHJOIJNKI());

	private UnknownFieldSet _unknownFields;

	public const int FJBENBJDFODFieldNumber = 10;

	private uint fJBENBJDFOD_;

	public const int StageTypeFieldNumber = 14;

	private uint stageType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LBKHJOIJNKI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LBKHJOIJNKIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FJBENBJDFOD
	{
		get
		{
			return fJBENBJDFOD_;
		}
		set
		{
			fJBENBJDFOD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageType
	{
		get
		{
			return stageType_;
		}
		set
		{
			stageType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBKHJOIJNKI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBKHJOIJNKI(LBKHJOIJNKI other)
		: this()
	{
		fJBENBJDFOD_ = other.fJBENBJDFOD_;
		stageType_ = other.stageType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBKHJOIJNKI Clone()
	{
		return new LBKHJOIJNKI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LBKHJOIJNKI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LBKHJOIJNKI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FJBENBJDFOD != other.FJBENBJDFOD)
		{
			return false;
		}
		if (StageType != other.StageType)
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
		if (FJBENBJDFOD != 0)
		{
			num ^= FJBENBJDFOD.GetHashCode();
		}
		if (StageType != 0)
		{
			num ^= StageType.GetHashCode();
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
		if (FJBENBJDFOD != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(FJBENBJDFOD);
		}
		if (StageType != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(StageType);
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
		if (FJBENBJDFOD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FJBENBJDFOD);
		}
		if (StageType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LBKHJOIJNKI other)
	{
		if (other != null)
		{
			if (other.FJBENBJDFOD != 0)
			{
				FJBENBJDFOD = other.FJBENBJDFOD;
			}
			if (other.StageType != 0)
			{
				StageType = other.StageType;
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
			case 80u:
				FJBENBJDFOD = input.ReadUInt32();
				break;
			case 112u:
				StageType = input.ReadUInt32();
				break;
			}
		}
	}
}
