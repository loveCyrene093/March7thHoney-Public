using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainCakeCatchSearchCsReq : IMessage<TrainCakeCatchSearchCsReq>, IMessage, IEquatable<TrainCakeCatchSearchCsReq>, IDeepCloneable<TrainCakeCatchSearchCsReq>, IBufferMessage
{
	private static readonly MessageParser<TrainCakeCatchSearchCsReq> _parser = new MessageParser<TrainCakeCatchSearchCsReq>(() => new TrainCakeCatchSearchCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HCJPDNDOHAMFieldNumber = 12;

	private uint hCJPDNDOHAM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainCakeCatchSearchCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainCakeCatchSearchCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCJPDNDOHAM
	{
		get
		{
			return hCJPDNDOHAM_;
		}
		set
		{
			hCJPDNDOHAM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchSearchCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchSearchCsReq(TrainCakeCatchSearchCsReq other)
		: this()
	{
		hCJPDNDOHAM_ = other.hCJPDNDOHAM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchSearchCsReq Clone()
	{
		return new TrainCakeCatchSearchCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainCakeCatchSearchCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainCakeCatchSearchCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HCJPDNDOHAM != other.HCJPDNDOHAM)
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
		if (HCJPDNDOHAM != 0)
		{
			num ^= HCJPDNDOHAM.GetHashCode();
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
		if (HCJPDNDOHAM != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(HCJPDNDOHAM);
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
		if (HCJPDNDOHAM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCJPDNDOHAM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainCakeCatchSearchCsReq other)
	{
		if (other != null)
		{
			if (other.HCJPDNDOHAM != 0)
			{
				HCJPDNDOHAM = other.HCJPDNDOHAM;
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
			if (num != 96)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				HCJPDNDOHAM = input.ReadUInt32();
			}
		}
	}
}
