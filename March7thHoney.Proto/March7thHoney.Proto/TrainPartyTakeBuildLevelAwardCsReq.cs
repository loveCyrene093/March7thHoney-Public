using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyTakeBuildLevelAwardCsReq : IMessage<TrainPartyTakeBuildLevelAwardCsReq>, IMessage, IEquatable<TrainPartyTakeBuildLevelAwardCsReq>, IDeepCloneable<TrainPartyTakeBuildLevelAwardCsReq>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyTakeBuildLevelAwardCsReq> _parser = new MessageParser<TrainPartyTakeBuildLevelAwardCsReq>(() => new TrainPartyTakeBuildLevelAwardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HBLOHOFKKKOFieldNumber = 15;

	private uint hBLOHOFKKKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyTakeBuildLevelAwardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyTakeBuildLevelAwardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HBLOHOFKKKO
	{
		get
		{
			return hBLOHOFKKKO_;
		}
		set
		{
			hBLOHOFKKKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyTakeBuildLevelAwardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyTakeBuildLevelAwardCsReq(TrainPartyTakeBuildLevelAwardCsReq other)
		: this()
	{
		hBLOHOFKKKO_ = other.hBLOHOFKKKO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyTakeBuildLevelAwardCsReq Clone()
	{
		return new TrainPartyTakeBuildLevelAwardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyTakeBuildLevelAwardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyTakeBuildLevelAwardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HBLOHOFKKKO != other.HBLOHOFKKKO)
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
		if (HBLOHOFKKKO != 0)
		{
			num ^= HBLOHOFKKKO.GetHashCode();
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
		if (HBLOHOFKKKO != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(HBLOHOFKKKO);
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
		if (HBLOHOFKKKO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBLOHOFKKKO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyTakeBuildLevelAwardCsReq other)
	{
		if (other != null)
		{
			if (other.HBLOHOFKKKO != 0)
			{
				HBLOHOFKKKO = other.HBLOHOFKKKO;
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
			if (num != 120)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				HBLOHOFKKKO = input.ReadUInt32();
			}
		}
	}
}
