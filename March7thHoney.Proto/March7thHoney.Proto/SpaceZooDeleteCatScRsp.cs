using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpaceZooDeleteCatScRsp : IMessage<SpaceZooDeleteCatScRsp>, IMessage, IEquatable<SpaceZooDeleteCatScRsp>, IDeepCloneable<SpaceZooDeleteCatScRsp>, IBufferMessage
{
	private static readonly MessageParser<SpaceZooDeleteCatScRsp> _parser = new MessageParser<SpaceZooDeleteCatScRsp>(() => new SpaceZooDeleteCatScRsp());

	private UnknownFieldSet _unknownFields;

	public const int NIEHHDLEANMFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_nIEHHDLEANM_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> nIEHHDLEANM_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpaceZooDeleteCatScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SpaceZooDeleteCatScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NIEHHDLEANM => nIEHHDLEANM_;

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
	public SpaceZooDeleteCatScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooDeleteCatScRsp(SpaceZooDeleteCatScRsp other)
		: this()
	{
		nIEHHDLEANM_ = other.nIEHHDLEANM_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooDeleteCatScRsp Clone()
	{
		return new SpaceZooDeleteCatScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SpaceZooDeleteCatScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpaceZooDeleteCatScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nIEHHDLEANM_.Equals(other.nIEHHDLEANM_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= nIEHHDLEANM_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		nIEHHDLEANM_.WriteTo(ref output, _repeated_nIEHHDLEANM_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
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
		num += nIEHHDLEANM_.CalculateSize(_repeated_nIEHHDLEANM_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpaceZooDeleteCatScRsp other)
	{
		if (other != null)
		{
			nIEHHDLEANM_.Add(other.nIEHHDLEANM_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 10u:
				nIEHHDLEANM_.AddEntriesFrom(ref input, _repeated_nIEHHDLEANM_codec);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
