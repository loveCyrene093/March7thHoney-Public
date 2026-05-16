using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TarotBookUnlockStoryScRsp : IMessage<TarotBookUnlockStoryScRsp>, IMessage, IEquatable<TarotBookUnlockStoryScRsp>, IDeepCloneable<TarotBookUnlockStoryScRsp>, IBufferMessage
{
	private static readonly MessageParser<TarotBookUnlockStoryScRsp> _parser = new MessageParser<TarotBookUnlockStoryScRsp>(() => new TarotBookUnlockStoryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CJLGPCAOPFCFieldNumber = 2;

	private static readonly MapField<uint, uint>.Codec _map_cJLGPCAOPFC_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 18u);

	private readonly MapField<uint, uint> cJLGPCAOPFC_ = new MapField<uint, uint>();

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int CCCKMACKLKGFieldNumber = 8;

	private static readonly MapField<uint, uint>.Codec _map_cCCKMACKLKG_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 66u);

	private readonly MapField<uint, uint> cCCKMACKLKG_ = new MapField<uint, uint>();

	public const int PFKHIIFBNDDFieldNumber = 9;

	private IPJOJKPBFGK pFKHIIFBNDD_;

	public const int LEGLOIMNPECFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_lEGLOIMNPEC_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> lEGLOIMNPEC_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TarotBookUnlockStoryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TarotBookUnlockStoryScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> CJLGPCAOPFC => cJLGPCAOPFC_;

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
	public MapField<uint, uint> CCCKMACKLKG => cCCKMACKLKG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPJOJKPBFGK PFKHIIFBNDD
	{
		get
		{
			return pFKHIIFBNDD_;
		}
		set
		{
			pFKHIIFBNDD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LEGLOIMNPEC => lEGLOIMNPEC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookUnlockStoryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookUnlockStoryScRsp(TarotBookUnlockStoryScRsp other)
		: this()
	{
		cJLGPCAOPFC_ = other.cJLGPCAOPFC_.Clone();
		retcode_ = other.retcode_;
		cCCKMACKLKG_ = other.cCCKMACKLKG_.Clone();
		pFKHIIFBNDD_ = ((other.pFKHIIFBNDD_ != null) ? other.pFKHIIFBNDD_.Clone() : null);
		lEGLOIMNPEC_ = other.lEGLOIMNPEC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookUnlockStoryScRsp Clone()
	{
		return new TarotBookUnlockStoryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TarotBookUnlockStoryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TarotBookUnlockStoryScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!CJLGPCAOPFC.Equals(other.CJLGPCAOPFC))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!CCCKMACKLKG.Equals(other.CCCKMACKLKG))
		{
			return false;
		}
		if (!object.Equals(PFKHIIFBNDD, other.PFKHIIFBNDD))
		{
			return false;
		}
		if (!lEGLOIMNPEC_.Equals(other.lEGLOIMNPEC_))
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
		num ^= CJLGPCAOPFC.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= CCCKMACKLKG.GetHashCode();
		if (pFKHIIFBNDD_ != null)
		{
			num ^= PFKHIIFBNDD.GetHashCode();
		}
		num ^= lEGLOIMNPEC_.GetHashCode();
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
		cJLGPCAOPFC_.WriteTo(ref output, _map_cJLGPCAOPFC_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		cCCKMACKLKG_.WriteTo(ref output, _map_cCCKMACKLKG_codec);
		if (pFKHIIFBNDD_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(PFKHIIFBNDD);
		}
		lEGLOIMNPEC_.WriteTo(ref output, _repeated_lEGLOIMNPEC_codec);
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
		num += cJLGPCAOPFC_.CalculateSize(_map_cJLGPCAOPFC_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += cCCKMACKLKG_.CalculateSize(_map_cCCKMACKLKG_codec);
		if (pFKHIIFBNDD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PFKHIIFBNDD);
		}
		num += lEGLOIMNPEC_.CalculateSize(_repeated_lEGLOIMNPEC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TarotBookUnlockStoryScRsp other)
	{
		if (other == null)
		{
			return;
		}
		cJLGPCAOPFC_.MergeFrom(other.cJLGPCAOPFC_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		cCCKMACKLKG_.MergeFrom(other.cCCKMACKLKG_);
		if (other.pFKHIIFBNDD_ != null)
		{
			if (pFKHIIFBNDD_ == null)
			{
				PFKHIIFBNDD = new IPJOJKPBFGK();
			}
			PFKHIIFBNDD.MergeFrom(other.PFKHIIFBNDD);
		}
		lEGLOIMNPEC_.Add(other.lEGLOIMNPEC_);
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
			case 18u:
				cJLGPCAOPFC_.AddEntriesFrom(ref input, _map_cJLGPCAOPFC_codec);
				break;
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 66u:
				cCCKMACKLKG_.AddEntriesFrom(ref input, _map_cCCKMACKLKG_codec);
				break;
			case 74u:
				if (pFKHIIFBNDD_ == null)
				{
					PFKHIIFBNDD = new IPJOJKPBFGK();
				}
				input.ReadMessage(PFKHIIFBNDD);
				break;
			case 80u:
			case 82u:
				lEGLOIMNPEC_.AddEntriesFrom(ref input, _repeated_lEGLOIMNPEC_codec);
				break;
			}
		}
	}
}
