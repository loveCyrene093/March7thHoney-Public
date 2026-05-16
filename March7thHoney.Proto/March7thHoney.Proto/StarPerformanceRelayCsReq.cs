using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StarPerformanceRelayCsReq : IMessage<StarPerformanceRelayCsReq>, IMessage, IEquatable<StarPerformanceRelayCsReq>, IDeepCloneable<StarPerformanceRelayCsReq>, IBufferMessage
{
	private static readonly MessageParser<StarPerformanceRelayCsReq> _parser = new MessageParser<StarPerformanceRelayCsReq>(() => new StarPerformanceRelayCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HFELBAKLHCAFieldNumber = 7;

	private uint hFELBAKLHCA_;

	public const int PerformanceIdFieldNumber = 13;

	private uint performanceId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StarPerformanceRelayCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StarPerformanceRelayCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HFELBAKLHCA
	{
		get
		{
			return hFELBAKLHCA_;
		}
		set
		{
			hFELBAKLHCA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PerformanceId
	{
		get
		{
			return performanceId_;
		}
		set
		{
			performanceId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StarPerformanceRelayCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StarPerformanceRelayCsReq(StarPerformanceRelayCsReq other)
		: this()
	{
		hFELBAKLHCA_ = other.hFELBAKLHCA_;
		performanceId_ = other.performanceId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StarPerformanceRelayCsReq Clone()
	{
		return new StarPerformanceRelayCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StarPerformanceRelayCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StarPerformanceRelayCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HFELBAKLHCA != other.HFELBAKLHCA)
		{
			return false;
		}
		if (PerformanceId != other.PerformanceId)
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
		if (HFELBAKLHCA != 0)
		{
			num ^= HFELBAKLHCA.GetHashCode();
		}
		if (PerformanceId != 0)
		{
			num ^= PerformanceId.GetHashCode();
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
		if (HFELBAKLHCA != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(HFELBAKLHCA);
		}
		if (PerformanceId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(PerformanceId);
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
		if (HFELBAKLHCA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HFELBAKLHCA);
		}
		if (PerformanceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PerformanceId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StarPerformanceRelayCsReq other)
	{
		if (other != null)
		{
			if (other.HFELBAKLHCA != 0)
			{
				HFELBAKLHCA = other.HFELBAKLHCA;
			}
			if (other.PerformanceId != 0)
			{
				PerformanceId = other.PerformanceId;
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
			case 56u:
				HFELBAKLHCA = input.ReadUInt32();
				break;
			case 104u:
				PerformanceId = input.ReadUInt32();
				break;
			}
		}
	}
}
