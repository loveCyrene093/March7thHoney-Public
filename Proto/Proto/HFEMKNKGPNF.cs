using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HFEMKNKGPNF : IMessage<HFEMKNKGPNF>, IMessage, IEquatable<HFEMKNKGPNF>, IDeepCloneable<HFEMKNKGPNF>, IBufferMessage
{
	private static readonly MessageParser<HFEMKNKGPNF> _parser = new MessageParser<HFEMKNKGPNF>(() => new HFEMKNKGPNF());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdListFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();

	public const int BKKFBLPBNMOFieldNumber = 2;

	private static readonly FieldCodec<GGCFFJGCPKD> _repeated_bKKFBLPBNMO_codec = FieldCodec.ForEnum(18u, (GGCFFJGCPKD x) => (int)x, (int x) => (GGCFFJGCPKD)x);

	private readonly RepeatedField<GGCFFJGCPKD> bKKFBLPBNMO_ = new RepeatedField<GGCFFJGCPKD>();

	public const int PACEGLACPHHFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_pACEGLACPHH_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> pACEGLACPHH_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HFEMKNKGPNF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HFEMKNKGPNFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AvatarIdList => avatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GGCFFJGCPKD> BKKFBLPBNMO => bKKFBLPBNMO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PACEGLACPHH => pACEGLACPHH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HFEMKNKGPNF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HFEMKNKGPNF(HFEMKNKGPNF other)
		: this()
	{
		avatarIdList_ = other.avatarIdList_.Clone();
		bKKFBLPBNMO_ = other.bKKFBLPBNMO_.Clone();
		pACEGLACPHH_ = other.pACEGLACPHH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HFEMKNKGPNF Clone()
	{
		return new HFEMKNKGPNF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HFEMKNKGPNF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HFEMKNKGPNF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarIdList_.Equals(other.avatarIdList_))
		{
			return false;
		}
		if (!bKKFBLPBNMO_.Equals(other.bKKFBLPBNMO_))
		{
			return false;
		}
		if (!pACEGLACPHH_.Equals(other.pACEGLACPHH_))
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
		num ^= avatarIdList_.GetHashCode();
		num ^= bKKFBLPBNMO_.GetHashCode();
		num ^= pACEGLACPHH_.GetHashCode();
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
		avatarIdList_.WriteTo(ref output, _repeated_avatarIdList_codec);
		bKKFBLPBNMO_.WriteTo(ref output, _repeated_bKKFBLPBNMO_codec);
		pACEGLACPHH_.WriteTo(ref output, _repeated_pACEGLACPHH_codec);
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
		num += avatarIdList_.CalculateSize(_repeated_avatarIdList_codec);
		num += bKKFBLPBNMO_.CalculateSize(_repeated_bKKFBLPBNMO_codec);
		num += pACEGLACPHH_.CalculateSize(_repeated_pACEGLACPHH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HFEMKNKGPNF other)
	{
		if (other != null)
		{
			avatarIdList_.Add(other.avatarIdList_);
			bKKFBLPBNMO_.Add(other.bKKFBLPBNMO_);
			pACEGLACPHH_.Add(other.pACEGLACPHH_);
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
			case 10u:
				avatarIdList_.AddEntriesFrom(ref input, _repeated_avatarIdList_codec);
				break;
			case 16u:
			case 18u:
				bKKFBLPBNMO_.AddEntriesFrom(ref input, _repeated_bKKFBLPBNMO_codec);
				break;
			case 24u:
			case 26u:
				pACEGLACPHH_.AddEntriesFrom(ref input, _repeated_pACEGLACPHH_codec);
				break;
			}
		}
	}
}
