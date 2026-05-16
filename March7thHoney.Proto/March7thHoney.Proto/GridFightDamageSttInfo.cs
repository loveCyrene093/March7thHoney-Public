using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightDamageSttInfo : IMessage<GridFightDamageSttInfo>, IMessage, IEquatable<GridFightDamageSttInfo>, IDeepCloneable<GridFightDamageSttInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightDamageSttInfo> _parser = new MessageParser<GridFightDamageSttInfo>(() => new GridFightDamageSttInfo());

	private UnknownFieldSet _unknownFields;

	public const int EABPCKEDDBHFieldNumber = 1;

	private static readonly FieldCodec<HHHMMJBGCNG> _repeated_eABPCKEDDBH_codec = FieldCodec.ForMessage(10u, HHHMMJBGCNG.Parser);

	private readonly RepeatedField<HHHMMJBGCNG> eABPCKEDDBH_ = new RepeatedField<HHHMMJBGCNG>();

	public const int MOIDLNFKAICFieldNumber = 3;

	private static readonly FieldCodec<ELAGCLMOFFI> _repeated_mOIDLNFKAIC_codec = FieldCodec.ForMessage(26u, ELAGCLMOFFI.Parser);

	private readonly RepeatedField<ELAGCLMOFFI> mOIDLNFKAIC_ = new RepeatedField<ELAGCLMOFFI>();

	public const int PHDEOPEJIIDFieldNumber = 13;

	private static readonly FieldCodec<DACJDMPICEL> _repeated_pHDEOPEJIID_codec = FieldCodec.ForMessage(106u, DACJDMPICEL.Parser);

	private readonly RepeatedField<DACJDMPICEL> pHDEOPEJIID_ = new RepeatedField<DACJDMPICEL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightDamageSttInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDamageSttInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HHHMMJBGCNG> EABPCKEDDBH => eABPCKEDDBH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ELAGCLMOFFI> MOIDLNFKAIC => mOIDLNFKAIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DACJDMPICEL> PHDEOPEJIID => pHDEOPEJIID_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightDamageSttInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightDamageSttInfo(GridFightDamageSttInfo other)
		: this()
	{
		eABPCKEDDBH_ = other.eABPCKEDDBH_.Clone();
		mOIDLNFKAIC_ = other.mOIDLNFKAIC_.Clone();
		pHDEOPEJIID_ = other.pHDEOPEJIID_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightDamageSttInfo Clone()
	{
		return new GridFightDamageSttInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightDamageSttInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightDamageSttInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eABPCKEDDBH_.Equals(other.eABPCKEDDBH_))
		{
			return false;
		}
		if (!mOIDLNFKAIC_.Equals(other.mOIDLNFKAIC_))
		{
			return false;
		}
		if (!pHDEOPEJIID_.Equals(other.pHDEOPEJIID_))
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
		num ^= eABPCKEDDBH_.GetHashCode();
		num ^= mOIDLNFKAIC_.GetHashCode();
		num ^= pHDEOPEJIID_.GetHashCode();
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
		eABPCKEDDBH_.WriteTo(ref output, _repeated_eABPCKEDDBH_codec);
		mOIDLNFKAIC_.WriteTo(ref output, _repeated_mOIDLNFKAIC_codec);
		pHDEOPEJIID_.WriteTo(ref output, _repeated_pHDEOPEJIID_codec);
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
		num += eABPCKEDDBH_.CalculateSize(_repeated_eABPCKEDDBH_codec);
		num += mOIDLNFKAIC_.CalculateSize(_repeated_mOIDLNFKAIC_codec);
		num += pHDEOPEJIID_.CalculateSize(_repeated_pHDEOPEJIID_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightDamageSttInfo other)
	{
		if (other != null)
		{
			eABPCKEDDBH_.Add(other.eABPCKEDDBH_);
			mOIDLNFKAIC_.Add(other.mOIDLNFKAIC_);
			pHDEOPEJIID_.Add(other.pHDEOPEJIID_);
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
				eABPCKEDDBH_.AddEntriesFrom(ref input, _repeated_eABPCKEDDBH_codec);
				break;
			case 26u:
				mOIDLNFKAIC_.AddEntriesFrom(ref input, _repeated_mOIDLNFKAIC_codec);
				break;
			case 106u:
				pHDEOPEJIID_.AddEntriesFrom(ref input, _repeated_pHDEOPEJIID_codec);
				break;
			}
		}
	}
}
