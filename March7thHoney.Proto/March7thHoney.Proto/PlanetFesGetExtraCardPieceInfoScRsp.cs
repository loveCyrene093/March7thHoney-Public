using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesGetExtraCardPieceInfoScRsp : IMessage<PlanetFesGetExtraCardPieceInfoScRsp>, IMessage, IEquatable<PlanetFesGetExtraCardPieceInfoScRsp>, IDeepCloneable<PlanetFesGetExtraCardPieceInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesGetExtraCardPieceInfoScRsp> _parser = new MessageParser<PlanetFesGetExtraCardPieceInfoScRsp>(() => new PlanetFesGetExtraCardPieceInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ADJEEIILGBOFieldNumber = 6;

	private PEHOCGJJMNF aDJEEIILGBO_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesGetExtraCardPieceInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesGetExtraCardPieceInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PEHOCGJJMNF ADJEEIILGBO
	{
		get
		{
			return aDJEEIILGBO_;
		}
		set
		{
			aDJEEIILGBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetExtraCardPieceInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetExtraCardPieceInfoScRsp(PlanetFesGetExtraCardPieceInfoScRsp other)
		: this()
	{
		aDJEEIILGBO_ = ((other.aDJEEIILGBO_ != null) ? other.aDJEEIILGBO_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetExtraCardPieceInfoScRsp Clone()
	{
		return new PlanetFesGetExtraCardPieceInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesGetExtraCardPieceInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesGetExtraCardPieceInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ADJEEIILGBO, other.ADJEEIILGBO))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (aDJEEIILGBO_ != null)
		{
			num ^= ADJEEIILGBO.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (aDJEEIILGBO_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ADJEEIILGBO);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
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
		if (aDJEEIILGBO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ADJEEIILGBO);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesGetExtraCardPieceInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aDJEEIILGBO_ != null)
		{
			if (aDJEEIILGBO_ == null)
			{
				ADJEEIILGBO = new PEHOCGJJMNF();
			}
			ADJEEIILGBO.MergeFrom(other.ADJEEIILGBO);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 50u:
				if (aDJEEIILGBO_ == null)
				{
					ADJEEIILGBO = new PEHOCGJJMNF();
				}
				input.ReadMessage(ADJEEIILGBO);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
