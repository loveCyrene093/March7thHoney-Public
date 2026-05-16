using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGetArchiveScRsp : IMessage<GridFightGetArchiveScRsp>, IMessage, IEquatable<GridFightGetArchiveScRsp>, IDeepCloneable<GridFightGetArchiveScRsp>, IBufferMessage
{
	private static readonly MessageParser<GridFightGetArchiveScRsp> _parser = new MessageParser<GridFightGetArchiveScRsp>(() => new GridFightGetArchiveScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int KGKIDDOPHEOFieldNumber = 10;

	private static readonly FieldCodec<GridFightArchiveData> _repeated_kGKIDDOPHEO_codec = FieldCodec.ForMessage(82u, GridFightArchiveData.Parser);

	private readonly RepeatedField<GridFightArchiveData> kGKIDDOPHEO_ = new RepeatedField<GridFightArchiveData>();

	public const int TypeFieldNumber = 12;

	private APDPAECJPIH type_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGetArchiveScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGetArchiveScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<GridFightArchiveData> KGKIDDOPHEO => kGKIDDOPHEO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APDPAECJPIH Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGetArchiveScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGetArchiveScRsp(GridFightGetArchiveScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		kGKIDDOPHEO_ = other.kGKIDDOPHEO_.Clone();
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGetArchiveScRsp Clone()
	{
		return new GridFightGetArchiveScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGetArchiveScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGetArchiveScRsp other)
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
		if (!kGKIDDOPHEO_.Equals(other.kGKIDDOPHEO_))
		{
			return false;
		}
		if (Type != other.Type)
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
		num ^= kGKIDDOPHEO_.GetHashCode();
		if (Type != APDPAECJPIH.Aobedaeijkh)
		{
			num ^= Type.GetHashCode();
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
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		kGKIDDOPHEO_.WriteTo(ref output, _repeated_kGKIDDOPHEO_codec);
		if (Type != APDPAECJPIH.Aobedaeijkh)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)Type);
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
		num += kGKIDDOPHEO_.CalculateSize(_repeated_kGKIDDOPHEO_codec);
		if (Type != APDPAECJPIH.Aobedaeijkh)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGetArchiveScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			kGKIDDOPHEO_.Add(other.kGKIDDOPHEO_);
			if (other.Type != APDPAECJPIH.Aobedaeijkh)
			{
				Type = other.Type;
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
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 82u:
				kGKIDDOPHEO_.AddEntriesFrom(ref input, _repeated_kGKIDDOPHEO_codec);
				break;
			case 96u:
				Type = (APDPAECJPIH)input.ReadEnum();
				break;
			}
		}
	}
}
