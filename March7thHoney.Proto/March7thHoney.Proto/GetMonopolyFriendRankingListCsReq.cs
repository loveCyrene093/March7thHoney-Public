using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMonopolyFriendRankingListCsReq : IMessage<GetMonopolyFriendRankingListCsReq>, IMessage, IEquatable<GetMonopolyFriendRankingListCsReq>, IDeepCloneable<GetMonopolyFriendRankingListCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetMonopolyFriendRankingListCsReq> _parser = new MessageParser<GetMonopolyFriendRankingListCsReq>(() => new GetMonopolyFriendRankingListCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CHNPMIBHOAAFieldNumber = 2;

	private uint cHNPMIBHOAA_;

	public const int FKAKCCJCGAFFieldNumber = 3;

	private uint fKAKCCJCGAF_;

	public const int NNAOHMMIBEBFieldNumber = 5;

	private uint nNAOHMMIBEB_;

	public const int DLDGHJEJDPFFieldNumber = 11;

	private uint dLDGHJEJDPF_;

	public const int UidFieldNumber = 15;

	private uint uid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMonopolyFriendRankingListCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMonopolyFriendRankingListCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CHNPMIBHOAA
	{
		get
		{
			return cHNPMIBHOAA_;
		}
		set
		{
			cHNPMIBHOAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FKAKCCJCGAF
	{
		get
		{
			return fKAKCCJCGAF_;
		}
		set
		{
			fKAKCCJCGAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NNAOHMMIBEB
	{
		get
		{
			return nNAOHMMIBEB_;
		}
		set
		{
			nNAOHMMIBEB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DLDGHJEJDPF
	{
		get
		{
			return dLDGHJEJDPF_;
		}
		set
		{
			dLDGHJEJDPF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMonopolyFriendRankingListCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMonopolyFriendRankingListCsReq(GetMonopolyFriendRankingListCsReq other)
		: this()
	{
		cHNPMIBHOAA_ = other.cHNPMIBHOAA_;
		fKAKCCJCGAF_ = other.fKAKCCJCGAF_;
		nNAOHMMIBEB_ = other.nNAOHMMIBEB_;
		dLDGHJEJDPF_ = other.dLDGHJEJDPF_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMonopolyFriendRankingListCsReq Clone()
	{
		return new GetMonopolyFriendRankingListCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMonopolyFriendRankingListCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMonopolyFriendRankingListCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CHNPMIBHOAA != other.CHNPMIBHOAA)
		{
			return false;
		}
		if (FKAKCCJCGAF != other.FKAKCCJCGAF)
		{
			return false;
		}
		if (NNAOHMMIBEB != other.NNAOHMMIBEB)
		{
			return false;
		}
		if (DLDGHJEJDPF != other.DLDGHJEJDPF)
		{
			return false;
		}
		if (Uid != other.Uid)
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
		if (CHNPMIBHOAA != 0)
		{
			num ^= CHNPMIBHOAA.GetHashCode();
		}
		if (FKAKCCJCGAF != 0)
		{
			num ^= FKAKCCJCGAF.GetHashCode();
		}
		if (NNAOHMMIBEB != 0)
		{
			num ^= NNAOHMMIBEB.GetHashCode();
		}
		if (DLDGHJEJDPF != 0)
		{
			num ^= DLDGHJEJDPF.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
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
		if (CHNPMIBHOAA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CHNPMIBHOAA);
		}
		if (FKAKCCJCGAF != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FKAKCCJCGAF);
		}
		if (NNAOHMMIBEB != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(NNAOHMMIBEB);
		}
		if (DLDGHJEJDPF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(DLDGHJEJDPF);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Uid);
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
		if (CHNPMIBHOAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHNPMIBHOAA);
		}
		if (FKAKCCJCGAF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FKAKCCJCGAF);
		}
		if (NNAOHMMIBEB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NNAOHMMIBEB);
		}
		if (DLDGHJEJDPF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DLDGHJEJDPF);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetMonopolyFriendRankingListCsReq other)
	{
		if (other != null)
		{
			if (other.CHNPMIBHOAA != 0)
			{
				CHNPMIBHOAA = other.CHNPMIBHOAA;
			}
			if (other.FKAKCCJCGAF != 0)
			{
				FKAKCCJCGAF = other.FKAKCCJCGAF;
			}
			if (other.NNAOHMMIBEB != 0)
			{
				NNAOHMMIBEB = other.NNAOHMMIBEB;
			}
			if (other.DLDGHJEJDPF != 0)
			{
				DLDGHJEJDPF = other.DLDGHJEJDPF;
			}
			if (other.Uid != 0)
			{
				Uid = other.Uid;
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
			case 16u:
				CHNPMIBHOAA = input.ReadUInt32();
				break;
			case 24u:
				FKAKCCJCGAF = input.ReadUInt32();
				break;
			case 40u:
				NNAOHMMIBEB = input.ReadUInt32();
				break;
			case 88u:
				DLDGHJEJDPF = input.ReadUInt32();
				break;
			case 120u:
				Uid = input.ReadUInt32();
				break;
			}
		}
	}
}
