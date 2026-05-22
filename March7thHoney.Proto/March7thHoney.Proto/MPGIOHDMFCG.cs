using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MPGIOHDMFCG : IMessage<MPGIOHDMFCG>, IMessage, IEquatable<MPGIOHDMFCG>, IDeepCloneable<MPGIOHDMFCG>, IBufferMessage
{
	private static readonly MessageParser<MPGIOHDMFCG> _parser = new MessageParser<MPGIOHDMFCG>(() => new MPGIOHDMFCG());

	private UnknownFieldSet _unknownFields;

	public const int MEAJAEBDAOIFieldNumber = 1;

	private uint mEAJAEBDAOI_;

	public const int IAMCPKMNANOFieldNumber = 4;

	private uint iAMCPKMNANO_;

	public const int EPFOIBHLDAOFieldNumber = 11;

	private uint ePFOIBHLDAO_;

	public const int PANFIPHAGPBFieldNumber = 15;

	private uint pANFIPHAGPB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MPGIOHDMFCG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MPGIOHDMFCGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MEAJAEBDAOI
	{
		get
		{
			return mEAJAEBDAOI_;
		}
		set
		{
			mEAJAEBDAOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IAMCPKMNANO
	{
		get
		{
			return iAMCPKMNANO_;
		}
		set
		{
			iAMCPKMNANO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EPFOIBHLDAO
	{
		get
		{
			return ePFOIBHLDAO_;
		}
		set
		{
			ePFOIBHLDAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PANFIPHAGPB
	{
		get
		{
			return pANFIPHAGPB_;
		}
		set
		{
			pANFIPHAGPB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPGIOHDMFCG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPGIOHDMFCG(MPGIOHDMFCG other)
		: this()
	{
		mEAJAEBDAOI_ = other.mEAJAEBDAOI_;
		iAMCPKMNANO_ = other.iAMCPKMNANO_;
		ePFOIBHLDAO_ = other.ePFOIBHLDAO_;
		pANFIPHAGPB_ = other.pANFIPHAGPB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPGIOHDMFCG Clone()
	{
		return new MPGIOHDMFCG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MPGIOHDMFCG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MPGIOHDMFCG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MEAJAEBDAOI != other.MEAJAEBDAOI)
		{
			return false;
		}
		if (IAMCPKMNANO != other.IAMCPKMNANO)
		{
			return false;
		}
		if (EPFOIBHLDAO != other.EPFOIBHLDAO)
		{
			return false;
		}
		if (PANFIPHAGPB != other.PANFIPHAGPB)
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
		if (MEAJAEBDAOI != 0)
		{
			num ^= MEAJAEBDAOI.GetHashCode();
		}
		if (IAMCPKMNANO != 0)
		{
			num ^= IAMCPKMNANO.GetHashCode();
		}
		if (EPFOIBHLDAO != 0)
		{
			num ^= EPFOIBHLDAO.GetHashCode();
		}
		if (PANFIPHAGPB != 0)
		{
			num ^= PANFIPHAGPB.GetHashCode();
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
		if (MEAJAEBDAOI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MEAJAEBDAOI);
		}
		if (IAMCPKMNANO != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(IAMCPKMNANO);
		}
		if (EPFOIBHLDAO != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(EPFOIBHLDAO);
		}
		if (PANFIPHAGPB != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(PANFIPHAGPB);
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
		if (MEAJAEBDAOI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MEAJAEBDAOI);
		}
		if (IAMCPKMNANO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IAMCPKMNANO);
		}
		if (EPFOIBHLDAO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPFOIBHLDAO);
		}
		if (PANFIPHAGPB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PANFIPHAGPB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MPGIOHDMFCG other)
	{
		if (other != null)
		{
			if (other.MEAJAEBDAOI != 0)
			{
				MEAJAEBDAOI = other.MEAJAEBDAOI;
			}
			if (other.IAMCPKMNANO != 0)
			{
				IAMCPKMNANO = other.IAMCPKMNANO;
			}
			if (other.EPFOIBHLDAO != 0)
			{
				EPFOIBHLDAO = other.EPFOIBHLDAO;
			}
			if (other.PANFIPHAGPB != 0)
			{
				PANFIPHAGPB = other.PANFIPHAGPB;
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
			case 8u:
				MEAJAEBDAOI = input.ReadUInt32();
				break;
			case 32u:
				IAMCPKMNANO = input.ReadUInt32();
				break;
			case 88u:
				EPFOIBHLDAO = input.ReadUInt32();
				break;
			case 120u:
				PANFIPHAGPB = input.ReadUInt32();
				break;
			}
		}
	}
}
