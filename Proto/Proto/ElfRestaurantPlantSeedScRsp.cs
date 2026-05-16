using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ElfRestaurantPlantSeedScRsp : IMessage<ElfRestaurantPlantSeedScRsp>, IMessage, IEquatable<ElfRestaurantPlantSeedScRsp>, IDeepCloneable<ElfRestaurantPlantSeedScRsp>, IBufferMessage
{
	private static readonly MessageParser<ElfRestaurantPlantSeedScRsp> _parser = new MessageParser<ElfRestaurantPlantSeedScRsp>(() => new ElfRestaurantPlantSeedScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MIMFMIICDGLFieldNumber = 1;

	private static readonly FieldCodec<KEHGPHDBOBD> _repeated_mIMFMIICDGL_codec = FieldCodec.ForMessage(10u, KEHGPHDBOBD.Parser);

	private readonly RepeatedField<KEHGPHDBOBD> mIMFMIICDGL_ = new RepeatedField<KEHGPHDBOBD>();

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int HNJFLFPLINIFieldNumber = 11;

	private static readonly FieldCodec<GKPPDJEFBPA> _repeated_hNJFLFPLINI_codec = FieldCodec.ForMessage(90u, GKPPDJEFBPA.Parser);

	private readonly RepeatedField<GKPPDJEFBPA> hNJFLFPLINI_ = new RepeatedField<GKPPDJEFBPA>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ElfRestaurantPlantSeedScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ElfRestaurantPlantSeedScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KEHGPHDBOBD> MIMFMIICDGL => mIMFMIICDGL_;

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
	public RepeatedField<GKPPDJEFBPA> HNJFLFPLINI => hNJFLFPLINI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantPlantSeedScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantPlantSeedScRsp(ElfRestaurantPlantSeedScRsp other)
		: this()
	{
		mIMFMIICDGL_ = other.mIMFMIICDGL_.Clone();
		retcode_ = other.retcode_;
		hNJFLFPLINI_ = other.hNJFLFPLINI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantPlantSeedScRsp Clone()
	{
		return new ElfRestaurantPlantSeedScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ElfRestaurantPlantSeedScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ElfRestaurantPlantSeedScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mIMFMIICDGL_.Equals(other.mIMFMIICDGL_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!hNJFLFPLINI_.Equals(other.hNJFLFPLINI_))
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
		num ^= mIMFMIICDGL_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= hNJFLFPLINI_.GetHashCode();
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
		mIMFMIICDGL_.WriteTo(ref output, _repeated_mIMFMIICDGL_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		hNJFLFPLINI_.WriteTo(ref output, _repeated_hNJFLFPLINI_codec);
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
		num += mIMFMIICDGL_.CalculateSize(_repeated_mIMFMIICDGL_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += hNJFLFPLINI_.CalculateSize(_repeated_hNJFLFPLINI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ElfRestaurantPlantSeedScRsp other)
	{
		if (other != null)
		{
			mIMFMIICDGL_.Add(other.mIMFMIICDGL_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			hNJFLFPLINI_.Add(other.hNJFLFPLINI_);
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
				mIMFMIICDGL_.AddEntriesFrom(ref input, _repeated_mIMFMIICDGL_codec);
				break;
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				hNJFLFPLINI_.AddEntriesFrom(ref input, _repeated_hNJFLFPLINI_codec);
				break;
			}
		}
	}
}
