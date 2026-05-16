using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetPunkLordDataScRsp : IMessage<GetPunkLordDataScRsp>, IMessage, IEquatable<GetPunkLordDataScRsp>, IDeepCloneable<GetPunkLordDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetPunkLordDataScRsp> _parser = new MessageParser<GetPunkLordDataScRsp>(() => new GetPunkLordDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int MPICOHMFGOAFieldNumber = 2;

	private uint mPICOHMFGOA_;

	public const int KFACMIDMBFFFieldNumber = 3;

	private uint kFACMIDMBFF_;

	public const int MOGBNJOHKLAFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_mOGBNJOHKLA_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> mOGBNJOHKLA_ = new RepeatedField<uint>();

	public const int DBAKNBHLNJKFieldNumber = 6;

	private uint dBAKNBHLNJK_;

	public const int EDANKPHGKKKFieldNumber = 8;

	private long eDANKPHGKKK_;

	public const int EJFEBCKDNNHFieldNumber = 12;

	private uint eJFEBCKDNNH_;

	public const int CLMONEEIEJEFieldNumber = 13;

	private uint cLMONEEIEJE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetPunkLordDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetPunkLordDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint MPICOHMFGOA
	{
		get
		{
			return mPICOHMFGOA_;
		}
		set
		{
			mPICOHMFGOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KFACMIDMBFF
	{
		get
		{
			return kFACMIDMBFF_;
		}
		set
		{
			kFACMIDMBFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MOGBNJOHKLA => mOGBNJOHKLA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DBAKNBHLNJK
	{
		get
		{
			return dBAKNBHLNJK_;
		}
		set
		{
			dBAKNBHLNJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EDANKPHGKKK
	{
		get
		{
			return eDANKPHGKKK_;
		}
		set
		{
			eDANKPHGKKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EJFEBCKDNNH
	{
		get
		{
			return eJFEBCKDNNH_;
		}
		set
		{
			eJFEBCKDNNH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CLMONEEIEJE
	{
		get
		{
			return cLMONEEIEJE_;
		}
		set
		{
			cLMONEEIEJE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPunkLordDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPunkLordDataScRsp(GetPunkLordDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		mPICOHMFGOA_ = other.mPICOHMFGOA_;
		kFACMIDMBFF_ = other.kFACMIDMBFF_;
		mOGBNJOHKLA_ = other.mOGBNJOHKLA_.Clone();
		dBAKNBHLNJK_ = other.dBAKNBHLNJK_;
		eDANKPHGKKK_ = other.eDANKPHGKKK_;
		eJFEBCKDNNH_ = other.eJFEBCKDNNH_;
		cLMONEEIEJE_ = other.cLMONEEIEJE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPunkLordDataScRsp Clone()
	{
		return new GetPunkLordDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetPunkLordDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetPunkLordDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (MPICOHMFGOA != other.MPICOHMFGOA)
		{
			return false;
		}
		if (KFACMIDMBFF != other.KFACMIDMBFF)
		{
			return false;
		}
		if (!mOGBNJOHKLA_.Equals(other.mOGBNJOHKLA_))
		{
			return false;
		}
		if (DBAKNBHLNJK != other.DBAKNBHLNJK)
		{
			return false;
		}
		if (EDANKPHGKKK != other.EDANKPHGKKK)
		{
			return false;
		}
		if (EJFEBCKDNNH != other.EJFEBCKDNNH)
		{
			return false;
		}
		if (CLMONEEIEJE != other.CLMONEEIEJE)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (MPICOHMFGOA != 0)
		{
			num ^= MPICOHMFGOA.GetHashCode();
		}
		if (KFACMIDMBFF != 0)
		{
			num ^= KFACMIDMBFF.GetHashCode();
		}
		num ^= mOGBNJOHKLA_.GetHashCode();
		if (DBAKNBHLNJK != 0)
		{
			num ^= DBAKNBHLNJK.GetHashCode();
		}
		if (EDANKPHGKKK != 0L)
		{
			num ^= EDANKPHGKKK.GetHashCode();
		}
		if (EJFEBCKDNNH != 0)
		{
			num ^= EJFEBCKDNNH.GetHashCode();
		}
		if (CLMONEEIEJE != 0)
		{
			num ^= CLMONEEIEJE.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (MPICOHMFGOA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MPICOHMFGOA);
		}
		if (KFACMIDMBFF != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(KFACMIDMBFF);
		}
		mOGBNJOHKLA_.WriteTo(ref output, _repeated_mOGBNJOHKLA_codec);
		if (DBAKNBHLNJK != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DBAKNBHLNJK);
		}
		if (EDANKPHGKKK != 0L)
		{
			output.WriteRawTag(64);
			output.WriteInt64(EDANKPHGKKK);
		}
		if (EJFEBCKDNNH != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(EJFEBCKDNNH);
		}
		if (CLMONEEIEJE != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CLMONEEIEJE);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (MPICOHMFGOA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MPICOHMFGOA);
		}
		if (KFACMIDMBFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KFACMIDMBFF);
		}
		num += mOGBNJOHKLA_.CalculateSize(_repeated_mOGBNJOHKLA_codec);
		if (DBAKNBHLNJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DBAKNBHLNJK);
		}
		if (EDANKPHGKKK != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EDANKPHGKKK);
		}
		if (EJFEBCKDNNH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EJFEBCKDNNH);
		}
		if (CLMONEEIEJE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CLMONEEIEJE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetPunkLordDataScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.MPICOHMFGOA != 0)
			{
				MPICOHMFGOA = other.MPICOHMFGOA;
			}
			if (other.KFACMIDMBFF != 0)
			{
				KFACMIDMBFF = other.KFACMIDMBFF;
			}
			mOGBNJOHKLA_.Add(other.mOGBNJOHKLA_);
			if (other.DBAKNBHLNJK != 0)
			{
				DBAKNBHLNJK = other.DBAKNBHLNJK;
			}
			if (other.EDANKPHGKKK != 0L)
			{
				EDANKPHGKKK = other.EDANKPHGKKK;
			}
			if (other.EJFEBCKDNNH != 0)
			{
				EJFEBCKDNNH = other.EJFEBCKDNNH;
			}
			if (other.CLMONEEIEJE != 0)
			{
				CLMONEEIEJE = other.CLMONEEIEJE;
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
				Retcode = input.ReadUInt32();
				break;
			case 16u:
				MPICOHMFGOA = input.ReadUInt32();
				break;
			case 24u:
				KFACMIDMBFF = input.ReadUInt32();
				break;
			case 32u:
			case 34u:
				mOGBNJOHKLA_.AddEntriesFrom(ref input, _repeated_mOGBNJOHKLA_codec);
				break;
			case 48u:
				DBAKNBHLNJK = input.ReadUInt32();
				break;
			case 64u:
				EDANKPHGKKK = input.ReadInt64();
				break;
			case 96u:
				EJFEBCKDNNH = input.ReadUInt32();
				break;
			case 104u:
				CLMONEEIEJE = input.ReadUInt32();
				break;
			}
		}
	}
}
