using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueWorkbenchGetInfoScRsp : IMessage<RogueWorkbenchGetInfoScRsp>, IMessage, IEquatable<RogueWorkbenchGetInfoScRsp>, IDeepCloneable<RogueWorkbenchGetInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueWorkbenchGetInfoScRsp> _parser = new MessageParser<RogueWorkbenchGetInfoScRsp>(() => new RogueWorkbenchGetInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int DKOAPDJGLOAFieldNumber = 12;

	private static readonly MapField<uint, CGKBEBCCDGF>.Codec _map_dKOAPDJGLOA_codec = new MapField<uint, CGKBEBCCDGF>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, CGKBEBCCDGF.Parser), 98u);

	private readonly MapField<uint, CGKBEBCCDGF> dKOAPDJGLOA_ = new MapField<uint, CGKBEBCCDGF>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueWorkbenchGetInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueWorkbenchGetInfoScRspReflection.Descriptor.MessageTypes[0];

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
	public MapField<uint, CGKBEBCCDGF> DKOAPDJGLOA => dKOAPDJGLOA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueWorkbenchGetInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueWorkbenchGetInfoScRsp(RogueWorkbenchGetInfoScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		dKOAPDJGLOA_ = other.dKOAPDJGLOA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueWorkbenchGetInfoScRsp Clone()
	{
		return new RogueWorkbenchGetInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueWorkbenchGetInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueWorkbenchGetInfoScRsp other)
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
		if (!DKOAPDJGLOA.Equals(other.DKOAPDJGLOA))
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
		num ^= DKOAPDJGLOA.GetHashCode();
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
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		dKOAPDJGLOA_.WriteTo(ref output, _map_dKOAPDJGLOA_codec);
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
		num += dKOAPDJGLOA_.CalculateSize(_map_dKOAPDJGLOA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueWorkbenchGetInfoScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			dKOAPDJGLOA_.MergeFrom(other.dKOAPDJGLOA_);
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
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				dKOAPDJGLOA_.AddEntriesFrom(ref input, _map_dKOAPDJGLOA_codec);
				break;
			}
		}
	}
}
