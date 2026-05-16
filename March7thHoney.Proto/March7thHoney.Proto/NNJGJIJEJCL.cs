using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NNJGJIJEJCL : IMessage<NNJGJIJEJCL>, IMessage, IEquatable<NNJGJIJEJCL>, IDeepCloneable<NNJGJIJEJCL>, IBufferMessage
{
	private static readonly MessageParser<NNJGJIJEJCL> _parser = new MessageParser<NNJGJIJEJCL>(() => new NNJGJIJEJCL());

	private UnknownFieldSet _unknownFields;

	public const int AJECCJKMHOGFieldNumber = 1;

	private bool aJECCJKMHOG_;

	public const int PHGGPFMFBALFieldNumber = 2;

	private static readonly MapField<string, FAEBBLFGAFF>.Codec _map_pHGGPFMFBAL_codec = new MapField<string, FAEBBLFGAFF>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForMessage(18u, FAEBBLFGAFF.Parser), 18u);

	private readonly MapField<string, FAEBBLFGAFF> pHGGPFMFBAL_ = new MapField<string, FAEBBLFGAFF>();

	public const int FCHAKFNDCNDFieldNumber = 3;

	private ByteString fCHAKFNDCND_ = ByteString.Empty;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NNJGJIJEJCL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NNJGJIJEJCLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AJECCJKMHOG
	{
		get
		{
			return aJECCJKMHOG_;
		}
		set
		{
			aJECCJKMHOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, FAEBBLFGAFF> PHGGPFMFBAL => pHGGPFMFBAL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString FCHAKFNDCND
	{
		get
		{
			return fCHAKFNDCND_;
		}
		set
		{
			fCHAKFNDCND_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNJGJIJEJCL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNJGJIJEJCL(NNJGJIJEJCL other)
		: this()
	{
		aJECCJKMHOG_ = other.aJECCJKMHOG_;
		pHGGPFMFBAL_ = other.pHGGPFMFBAL_.Clone();
		fCHAKFNDCND_ = other.fCHAKFNDCND_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNJGJIJEJCL Clone()
	{
		return new NNJGJIJEJCL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NNJGJIJEJCL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NNJGJIJEJCL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AJECCJKMHOG != other.AJECCJKMHOG)
		{
			return false;
		}
		if (!PHGGPFMFBAL.Equals(other.PHGGPFMFBAL))
		{
			return false;
		}
		if (FCHAKFNDCND != other.FCHAKFNDCND)
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
		if (AJECCJKMHOG)
		{
			num ^= AJECCJKMHOG.GetHashCode();
		}
		num ^= PHGGPFMFBAL.GetHashCode();
		if (FCHAKFNDCND.Length != 0)
		{
			num ^= FCHAKFNDCND.GetHashCode();
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
		if (AJECCJKMHOG)
		{
			output.WriteRawTag(8);
			output.WriteBool(AJECCJKMHOG);
		}
		pHGGPFMFBAL_.WriteTo(ref output, _map_pHGGPFMFBAL_codec);
		if (FCHAKFNDCND.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteBytes(FCHAKFNDCND);
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
		if (AJECCJKMHOG)
		{
			num += 2;
		}
		num += pHGGPFMFBAL_.CalculateSize(_map_pHGGPFMFBAL_codec);
		if (FCHAKFNDCND.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(FCHAKFNDCND);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NNJGJIJEJCL other)
	{
		if (other != null)
		{
			if (other.AJECCJKMHOG)
			{
				AJECCJKMHOG = other.AJECCJKMHOG;
			}
			pHGGPFMFBAL_.MergeFrom(other.pHGGPFMFBAL_);
			if (other.FCHAKFNDCND.Length != 0)
			{
				FCHAKFNDCND = other.FCHAKFNDCND;
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
				AJECCJKMHOG = input.ReadBool();
				break;
			case 18u:
				pHGGPFMFBAL_.AddEntriesFrom(ref input, _map_pHGGPFMFBAL_codec);
				break;
			case 26u:
				FCHAKFNDCND = input.ReadBytes();
				break;
			}
		}
	}
}
