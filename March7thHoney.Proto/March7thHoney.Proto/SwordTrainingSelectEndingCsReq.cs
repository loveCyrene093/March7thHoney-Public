using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwordTrainingSelectEndingCsReq : IMessage<SwordTrainingSelectEndingCsReq>, IMessage, IEquatable<SwordTrainingSelectEndingCsReq>, IDeepCloneable<SwordTrainingSelectEndingCsReq>, IBufferMessage
{
	private static readonly MessageParser<SwordTrainingSelectEndingCsReq> _parser = new MessageParser<SwordTrainingSelectEndingCsReq>(() => new SwordTrainingSelectEndingCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AGMAHIIHJKMFieldNumber = 8;

	private uint aGMAHIIHJKM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwordTrainingSelectEndingCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwordTrainingSelectEndingCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AGMAHIIHJKM
	{
		get
		{
			return aGMAHIIHJKM_;
		}
		set
		{
			aGMAHIIHJKM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingSelectEndingCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingSelectEndingCsReq(SwordTrainingSelectEndingCsReq other)
		: this()
	{
		aGMAHIIHJKM_ = other.aGMAHIIHJKM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingSelectEndingCsReq Clone()
	{
		return new SwordTrainingSelectEndingCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwordTrainingSelectEndingCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwordTrainingSelectEndingCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AGMAHIIHJKM != other.AGMAHIIHJKM)
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
		if (AGMAHIIHJKM != 0)
		{
			num ^= AGMAHIIHJKM.GetHashCode();
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
		if (AGMAHIIHJKM != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(AGMAHIIHJKM);
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
		if (AGMAHIIHJKM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AGMAHIIHJKM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SwordTrainingSelectEndingCsReq other)
	{
		if (other != null)
		{
			if (other.AGMAHIIHJKM != 0)
			{
				AGMAHIIHJKM = other.AGMAHIIHJKM;
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
			if (num != 64)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				AGMAHIIHJKM = input.ReadUInt32();
			}
		}
	}
}
