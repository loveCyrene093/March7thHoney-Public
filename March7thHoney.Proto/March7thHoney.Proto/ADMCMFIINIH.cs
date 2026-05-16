using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ADMCMFIINIH : IMessage<ADMCMFIINIH>, IMessage, IEquatable<ADMCMFIINIH>, IDeepCloneable<ADMCMFIINIH>, IBufferMessage
{
	private static readonly MessageParser<ADMCMFIINIH> _parser = new MessageParser<ADMCMFIINIH>(() => new ADMCMFIINIH());

	private UnknownFieldSet _unknownFields;

	public const int MOHOBFPJPMLFieldNumber = 1;

	private uint mOHOBFPJPML_;

	public const int EOGMIHEPCGMFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_eOGMIHEPCGM_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> eOGMIHEPCGM_ = new RepeatedField<uint>();

	public const int IdFieldNumber = 9;

	private uint id_;

	public const int IsNewFieldNumber = 10;

	private bool isNew_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ADMCMFIINIH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ADMCMFIINIHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOHOBFPJPML
	{
		get
		{
			return mOHOBFPJPML_;
		}
		set
		{
			mOHOBFPJPML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EOGMIHEPCGM => eOGMIHEPCGM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsNew
	{
		get
		{
			return isNew_;
		}
		set
		{
			isNew_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADMCMFIINIH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADMCMFIINIH(ADMCMFIINIH other)
		: this()
	{
		mOHOBFPJPML_ = other.mOHOBFPJPML_;
		eOGMIHEPCGM_ = other.eOGMIHEPCGM_.Clone();
		id_ = other.id_;
		isNew_ = other.isNew_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADMCMFIINIH Clone()
	{
		return new ADMCMFIINIH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ADMCMFIINIH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ADMCMFIINIH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MOHOBFPJPML != other.MOHOBFPJPML)
		{
			return false;
		}
		if (!eOGMIHEPCGM_.Equals(other.eOGMIHEPCGM_))
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (IsNew != other.IsNew)
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
		if (MOHOBFPJPML != 0)
		{
			num ^= MOHOBFPJPML.GetHashCode();
		}
		num ^= eOGMIHEPCGM_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsNew)
		{
			num ^= IsNew.GetHashCode();
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
		if (MOHOBFPJPML != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MOHOBFPJPML);
		}
		eOGMIHEPCGM_.WriteTo(ref output, _repeated_eOGMIHEPCGM_codec);
		if (Id != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Id);
		}
		if (IsNew)
		{
			output.WriteRawTag(80);
			output.WriteBool(IsNew);
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
		if (MOHOBFPJPML != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOHOBFPJPML);
		}
		num += eOGMIHEPCGM_.CalculateSize(_repeated_eOGMIHEPCGM_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (IsNew)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ADMCMFIINIH other)
	{
		if (other != null)
		{
			if (other.MOHOBFPJPML != 0)
			{
				MOHOBFPJPML = other.MOHOBFPJPML;
			}
			eOGMIHEPCGM_.Add(other.eOGMIHEPCGM_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsNew)
			{
				IsNew = other.IsNew;
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
				MOHOBFPJPML = input.ReadUInt32();
				break;
			case 16u:
			case 18u:
				eOGMIHEPCGM_.AddEntriesFrom(ref input, _repeated_eOGMIHEPCGM_codec);
				break;
			case 72u:
				Id = input.ReadUInt32();
				break;
			case 80u:
				IsNew = input.ReadBool();
				break;
			}
		}
	}
}
