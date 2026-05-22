using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFightActivityDataScRsp : IMessage<GetFightActivityDataScRsp>, IMessage, IEquatable<GetFightActivityDataScRsp>, IDeepCloneable<GetFightActivityDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetFightActivityDataScRsp> _parser = new MessageParser<GetFightActivityDataScRsp>(() => new GetFightActivityDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int IMGGPMEOJAJFieldNumber = 1;

	private static readonly MapField<uint, uint>.Codec _map_iMGGPMEOJAJ_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 10u);

	private readonly MapField<uint, uint> iMGGPMEOJAJ_ = new MapField<uint, uint>();

	public const int IBCMLDPJGCKFieldNumber = 2;

	private bool iBCMLDPJGCK_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int ECGLGDKDDIDFieldNumber = 10;

	private static readonly FieldCodec<IFNECJOOIGG> _repeated_eCGLGDKDDID_codec = FieldCodec.ForMessage(82u, IFNECJOOIGG.Parser);

	private readonly RepeatedField<IFNECJOOIGG> eCGLGDKDDID_ = new RepeatedField<IFNECJOOIGG>();

	public const int WorldLevelFieldNumber = 14;

	private uint worldLevel_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFightActivityDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFightActivityDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> IMGGPMEOJAJ => iMGGPMEOJAJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IBCMLDPJGCK
	{
		get
		{
			return iBCMLDPJGCK_;
		}
		set
		{
			iBCMLDPJGCK_ = value;
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
	public RepeatedField<IFNECJOOIGG> ECGLGDKDDID => eCGLGDKDDID_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint WorldLevel
	{
		get
		{
			return worldLevel_;
		}
		set
		{
			worldLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFightActivityDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFightActivityDataScRsp(GetFightActivityDataScRsp other)
		: this()
	{
		iMGGPMEOJAJ_ = other.iMGGPMEOJAJ_.Clone();
		iBCMLDPJGCK_ = other.iBCMLDPJGCK_;
		retcode_ = other.retcode_;
		eCGLGDKDDID_ = other.eCGLGDKDDID_.Clone();
		worldLevel_ = other.worldLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFightActivityDataScRsp Clone()
	{
		return new GetFightActivityDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFightActivityDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFightActivityDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!IMGGPMEOJAJ.Equals(other.IMGGPMEOJAJ))
		{
			return false;
		}
		if (IBCMLDPJGCK != other.IBCMLDPJGCK)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!eCGLGDKDDID_.Equals(other.eCGLGDKDDID_))
		{
			return false;
		}
		if (WorldLevel != other.WorldLevel)
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
		num ^= IMGGPMEOJAJ.GetHashCode();
		if (IBCMLDPJGCK)
		{
			num ^= IBCMLDPJGCK.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= eCGLGDKDDID_.GetHashCode();
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
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
		iMGGPMEOJAJ_.WriteTo(ref output, _map_iMGGPMEOJAJ_codec);
		if (IBCMLDPJGCK)
		{
			output.WriteRawTag(16);
			output.WriteBool(IBCMLDPJGCK);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		eCGLGDKDDID_.WriteTo(ref output, _repeated_eCGLGDKDDID_codec);
		if (WorldLevel != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(WorldLevel);
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
		num += iMGGPMEOJAJ_.CalculateSize(_map_iMGGPMEOJAJ_codec);
		if (IBCMLDPJGCK)
		{
			num += 2;
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += eCGLGDKDDID_.CalculateSize(_repeated_eCGLGDKDDID_codec);
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFightActivityDataScRsp other)
	{
		if (other != null)
		{
			iMGGPMEOJAJ_.MergeFrom(other.iMGGPMEOJAJ_);
			if (other.IBCMLDPJGCK)
			{
				IBCMLDPJGCK = other.IBCMLDPJGCK;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			eCGLGDKDDID_.Add(other.eCGLGDKDDID_);
			if (other.WorldLevel != 0)
			{
				WorldLevel = other.WorldLevel;
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
			case 10u:
				iMGGPMEOJAJ_.AddEntriesFrom(ref input, _map_iMGGPMEOJAJ_codec);
				break;
			case 16u:
				IBCMLDPJGCK = input.ReadBool();
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 82u:
				eCGLGDKDDID_.AddEntriesFrom(ref input, _repeated_eCGLGDKDDID_codec);
				break;
			case 112u:
				WorldLevel = input.ReadUInt32();
				break;
			}
		}
	}
}
