using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DGMLAAIHBFC : IMessage<DGMLAAIHBFC>, IMessage, IEquatable<DGMLAAIHBFC>, IDeepCloneable<DGMLAAIHBFC>, IBufferMessage
{
	private static readonly MessageParser<DGMLAAIHBFC> _parser = new MessageParser<DGMLAAIHBFC>(() => new DGMLAAIHBFC());

	private UnknownFieldSet _unknownFields;

	public const int MPIILLMLPJNFieldNumber = 1;

	private static readonly FieldCodec<IHGBDAGHDME> _repeated_mPIILLMLPJN_codec = FieldCodec.ForMessage(10u, IHGBDAGHDME.Parser);

	private readonly RepeatedField<IHGBDAGHDME> mPIILLMLPJN_ = new RepeatedField<IHGBDAGHDME>();

	public const int IIHADPGEAJBFieldNumber = 2;

	private static readonly MapField<uint, HMEDBGAMMPN>.Codec _map_iIHADPGEAJB_codec = new MapField<uint, HMEDBGAMMPN>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, HMEDBGAMMPN.Parser), 18u);

	private readonly MapField<uint, HMEDBGAMMPN> iIHADPGEAJB_ = new MapField<uint, HMEDBGAMMPN>();

	public const int DNOPHJFKKHCFieldNumber = 9;

	private HMEDBGAMMPN dNOPHJFKKHC_;

	public const int IPFPDJNFMMNFieldNumber = 13;

	private HMEDBGAMMPN iPFPDJNFMMN_;

	public const int NEEFACJBKPNFieldNumber = 15;

	private uint nEEFACJBKPN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DGMLAAIHBFC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DGMLAAIHBFCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IHGBDAGHDME> MPIILLMLPJN => mPIILLMLPJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, HMEDBGAMMPN> IIHADPGEAJB => iIHADPGEAJB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMEDBGAMMPN DNOPHJFKKHC
	{
		get
		{
			return dNOPHJFKKHC_;
		}
		set
		{
			dNOPHJFKKHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMEDBGAMMPN IPFPDJNFMMN
	{
		get
		{
			return iPFPDJNFMMN_;
		}
		set
		{
			iPFPDJNFMMN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NEEFACJBKPN
	{
		get
		{
			return nEEFACJBKPN_;
		}
		set
		{
			nEEFACJBKPN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGMLAAIHBFC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGMLAAIHBFC(DGMLAAIHBFC other)
		: this()
	{
		mPIILLMLPJN_ = other.mPIILLMLPJN_.Clone();
		iIHADPGEAJB_ = other.iIHADPGEAJB_.Clone();
		dNOPHJFKKHC_ = ((other.dNOPHJFKKHC_ != null) ? other.dNOPHJFKKHC_.Clone() : null);
		iPFPDJNFMMN_ = ((other.iPFPDJNFMMN_ != null) ? other.iPFPDJNFMMN_.Clone() : null);
		nEEFACJBKPN_ = other.nEEFACJBKPN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGMLAAIHBFC Clone()
	{
		return new DGMLAAIHBFC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DGMLAAIHBFC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DGMLAAIHBFC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mPIILLMLPJN_.Equals(other.mPIILLMLPJN_))
		{
			return false;
		}
		if (!IIHADPGEAJB.Equals(other.IIHADPGEAJB))
		{
			return false;
		}
		if (!object.Equals(DNOPHJFKKHC, other.DNOPHJFKKHC))
		{
			return false;
		}
		if (!object.Equals(IPFPDJNFMMN, other.IPFPDJNFMMN))
		{
			return false;
		}
		if (NEEFACJBKPN != other.NEEFACJBKPN)
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
		num ^= mPIILLMLPJN_.GetHashCode();
		num ^= IIHADPGEAJB.GetHashCode();
		if (dNOPHJFKKHC_ != null)
		{
			num ^= DNOPHJFKKHC.GetHashCode();
		}
		if (iPFPDJNFMMN_ != null)
		{
			num ^= IPFPDJNFMMN.GetHashCode();
		}
		if (NEEFACJBKPN != 0)
		{
			num ^= NEEFACJBKPN.GetHashCode();
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
		mPIILLMLPJN_.WriteTo(ref output, _repeated_mPIILLMLPJN_codec);
		iIHADPGEAJB_.WriteTo(ref output, _map_iIHADPGEAJB_codec);
		if (dNOPHJFKKHC_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(DNOPHJFKKHC);
		}
		if (iPFPDJNFMMN_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(IPFPDJNFMMN);
		}
		if (NEEFACJBKPN != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(NEEFACJBKPN);
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
		num += mPIILLMLPJN_.CalculateSize(_repeated_mPIILLMLPJN_codec);
		num += iIHADPGEAJB_.CalculateSize(_map_iIHADPGEAJB_codec);
		if (dNOPHJFKKHC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DNOPHJFKKHC);
		}
		if (iPFPDJNFMMN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IPFPDJNFMMN);
		}
		if (NEEFACJBKPN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NEEFACJBKPN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DGMLAAIHBFC other)
	{
		if (other == null)
		{
			return;
		}
		mPIILLMLPJN_.Add(other.mPIILLMLPJN_);
		iIHADPGEAJB_.MergeFrom(other.iIHADPGEAJB_);
		if (other.dNOPHJFKKHC_ != null)
		{
			if (dNOPHJFKKHC_ == null)
			{
				DNOPHJFKKHC = new HMEDBGAMMPN();
			}
			DNOPHJFKKHC.MergeFrom(other.DNOPHJFKKHC);
		}
		if (other.iPFPDJNFMMN_ != null)
		{
			if (iPFPDJNFMMN_ == null)
			{
				IPFPDJNFMMN = new HMEDBGAMMPN();
			}
			IPFPDJNFMMN.MergeFrom(other.IPFPDJNFMMN);
		}
		if (other.NEEFACJBKPN != 0)
		{
			NEEFACJBKPN = other.NEEFACJBKPN;
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
			case 10u:
				mPIILLMLPJN_.AddEntriesFrom(ref input, _repeated_mPIILLMLPJN_codec);
				break;
			case 18u:
				iIHADPGEAJB_.AddEntriesFrom(ref input, _map_iIHADPGEAJB_codec);
				break;
			case 74u:
				if (dNOPHJFKKHC_ == null)
				{
					DNOPHJFKKHC = new HMEDBGAMMPN();
				}
				input.ReadMessage(DNOPHJFKKHC);
				break;
			case 106u:
				if (iPFPDJNFMMN_ == null)
				{
					IPFPDJNFMMN = new HMEDBGAMMPN();
				}
				input.ReadMessage(IPFPDJNFMMN);
				break;
			case 120u:
				NEEFACJBKPN = input.ReadUInt32();
				break;
			}
		}
	}
}
