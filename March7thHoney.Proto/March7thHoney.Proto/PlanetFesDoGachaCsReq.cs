using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesDoGachaCsReq : IMessage<PlanetFesDoGachaCsReq>, IMessage, IEquatable<PlanetFesDoGachaCsReq>, IDeepCloneable<PlanetFesDoGachaCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesDoGachaCsReq> _parser = new MessageParser<PlanetFesDoGachaCsReq>(() => new PlanetFesDoGachaCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GachaCountFieldNumber = 5;

	private uint gachaCount_;

	public const int GachaIdFieldNumber = 10;

	private uint gachaId_;

	public const int SimulateMagicFieldNumber = 14;

	private uint simulateMagic_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesDoGachaCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesDoGachaCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaCount
	{
		get
		{
			return gachaCount_;
		}
		set
		{
			gachaCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaId
	{
		get
		{
			return gachaId_;
		}
		set
		{
			gachaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SimulateMagic
	{
		get
		{
			return simulateMagic_;
		}
		set
		{
			simulateMagic_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDoGachaCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDoGachaCsReq(PlanetFesDoGachaCsReq other)
		: this()
	{
		gachaCount_ = other.gachaCount_;
		gachaId_ = other.gachaId_;
		simulateMagic_ = other.simulateMagic_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDoGachaCsReq Clone()
	{
		return new PlanetFesDoGachaCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesDoGachaCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesDoGachaCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GachaCount != other.GachaCount)
		{
			return false;
		}
		if (GachaId != other.GachaId)
		{
			return false;
		}
		if (SimulateMagic != other.SimulateMagic)
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
		if (GachaCount != 0)
		{
			num ^= GachaCount.GetHashCode();
		}
		if (GachaId != 0)
		{
			num ^= GachaId.GetHashCode();
		}
		if (SimulateMagic != 0)
		{
			num ^= SimulateMagic.GetHashCode();
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
		if (GachaCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GachaCount);
		}
		if (GachaId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GachaId);
		}
		if (SimulateMagic != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(SimulateMagic);
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
		if (GachaCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaCount);
		}
		if (GachaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaId);
		}
		if (SimulateMagic != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SimulateMagic);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesDoGachaCsReq other)
	{
		if (other != null)
		{
			if (other.GachaCount != 0)
			{
				GachaCount = other.GachaCount;
			}
			if (other.GachaId != 0)
			{
				GachaId = other.GachaId;
			}
			if (other.SimulateMagic != 0)
			{
				SimulateMagic = other.SimulateMagic;
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
			case 40u:
				GachaCount = input.ReadUInt32();
				break;
			case 80u:
				GachaId = input.ReadUInt32();
				break;
			case 112u:
				SimulateMagic = input.ReadUInt32();
				break;
			}
		}
	}
}
