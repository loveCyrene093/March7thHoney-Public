using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PCAHGLCGODJ : IMessage<PCAHGLCGODJ>, IMessage, IEquatable<PCAHGLCGODJ>, IDeepCloneable<PCAHGLCGODJ>, IBufferMessage
{
	private static readonly MessageParser<PCAHGLCGODJ> _parser = new MessageParser<PCAHGLCGODJ>(() => new PCAHGLCGODJ());

	private UnknownFieldSet _unknownFields;

	public const int DCBJNILFBAGFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_dCBJNILFBAG_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> dCBJNILFBAG_ = new RepeatedField<uint>();

	public const int AFPPABBGPKFFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_aFPPABBGPKF_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> aFPPABBGPKF_ = new RepeatedField<uint>();

	public const int DBLKCEDDHIPFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_dBLKCEDDHIP_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> dBLKCEDDHIP_ = new RepeatedField<uint>();

	public const int LJAPNDAOEEOFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_lJAPNDAOEEO_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> lJAPNDAOEEO_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PCAHGLCGODJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PCAHGLCGODJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DCBJNILFBAG => dCBJNILFBAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AFPPABBGPKF => aFPPABBGPKF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DBLKCEDDHIP => dBLKCEDDHIP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LJAPNDAOEEO => lJAPNDAOEEO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCAHGLCGODJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCAHGLCGODJ(PCAHGLCGODJ other)
		: this()
	{
		dCBJNILFBAG_ = other.dCBJNILFBAG_.Clone();
		aFPPABBGPKF_ = other.aFPPABBGPKF_.Clone();
		dBLKCEDDHIP_ = other.dBLKCEDDHIP_.Clone();
		lJAPNDAOEEO_ = other.lJAPNDAOEEO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCAHGLCGODJ Clone()
	{
		return new PCAHGLCGODJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PCAHGLCGODJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PCAHGLCGODJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dCBJNILFBAG_.Equals(other.dCBJNILFBAG_))
		{
			return false;
		}
		if (!aFPPABBGPKF_.Equals(other.aFPPABBGPKF_))
		{
			return false;
		}
		if (!dBLKCEDDHIP_.Equals(other.dBLKCEDDHIP_))
		{
			return false;
		}
		if (!lJAPNDAOEEO_.Equals(other.lJAPNDAOEEO_))
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
		num ^= dCBJNILFBAG_.GetHashCode();
		num ^= aFPPABBGPKF_.GetHashCode();
		num ^= dBLKCEDDHIP_.GetHashCode();
		num ^= lJAPNDAOEEO_.GetHashCode();
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
		dCBJNILFBAG_.WriteTo(ref output, _repeated_dCBJNILFBAG_codec);
		aFPPABBGPKF_.WriteTo(ref output, _repeated_aFPPABBGPKF_codec);
		dBLKCEDDHIP_.WriteTo(ref output, _repeated_dBLKCEDDHIP_codec);
		lJAPNDAOEEO_.WriteTo(ref output, _repeated_lJAPNDAOEEO_codec);
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
		num += dCBJNILFBAG_.CalculateSize(_repeated_dCBJNILFBAG_codec);
		num += aFPPABBGPKF_.CalculateSize(_repeated_aFPPABBGPKF_codec);
		num += dBLKCEDDHIP_.CalculateSize(_repeated_dBLKCEDDHIP_codec);
		num += lJAPNDAOEEO_.CalculateSize(_repeated_lJAPNDAOEEO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PCAHGLCGODJ other)
	{
		if (other != null)
		{
			dCBJNILFBAG_.Add(other.dCBJNILFBAG_);
			aFPPABBGPKF_.Add(other.aFPPABBGPKF_);
			dBLKCEDDHIP_.Add(other.dBLKCEDDHIP_);
			lJAPNDAOEEO_.Add(other.lJAPNDAOEEO_);
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
				dCBJNILFBAG_.AddEntriesFrom(ref input, _repeated_dCBJNILFBAG_codec);
				break;
			case 16u:
			case 18u:
				aFPPABBGPKF_.AddEntriesFrom(ref input, _repeated_aFPPABBGPKF_codec);
				break;
			case 24u:
			case 26u:
				dBLKCEDDHIP_.AddEntriesFrom(ref input, _repeated_dBLKCEDDHIP_codec);
				break;
			case 32u:
			case 34u:
				lJAPNDAOEEO_.AddEntriesFrom(ref input, _repeated_lJAPNDAOEEO_codec);
				break;
			}
		}
	}
}
