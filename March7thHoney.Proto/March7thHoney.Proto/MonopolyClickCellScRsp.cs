using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyClickCellScRsp : IMessage<MonopolyClickCellScRsp>, IMessage, IEquatable<MonopolyClickCellScRsp>, IDeepCloneable<MonopolyClickCellScRsp>, IBufferMessage
{
	private static readonly MessageParser<MonopolyClickCellScRsp> _parser = new MessageParser<MonopolyClickCellScRsp>(() => new MonopolyClickCellScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MapIdFieldNumber = 3;

	private uint mapId_;

	public const int EIIAGABAFECFieldNumber = 6;

	private uint eIIAGABAFEC_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyClickCellScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyClickCellScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EIIAGABAFEC
	{
		get
		{
			return eIIAGABAFEC_;
		}
		set
		{
			eIIAGABAFEC_ = value;
		}
	}

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
	public MonopolyClickCellScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyClickCellScRsp(MonopolyClickCellScRsp other)
		: this()
	{
		mapId_ = other.mapId_;
		eIIAGABAFEC_ = other.eIIAGABAFEC_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyClickCellScRsp Clone()
	{
		return new MonopolyClickCellScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyClickCellScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyClickCellScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MapId != other.MapId)
		{
			return false;
		}
		if (EIIAGABAFEC != other.EIIAGABAFEC)
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
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (EIIAGABAFEC != 0)
		{
			num ^= EIIAGABAFEC.GetHashCode();
		}
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
		if (MapId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MapId);
		}
		if (EIIAGABAFEC != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(EIIAGABAFEC);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
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
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MapId);
		}
		if (EIIAGABAFEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EIIAGABAFEC);
		}
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
	public void MergeFrom(MonopolyClickCellScRsp other)
	{
		if (other != null)
		{
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.EIIAGABAFEC != 0)
			{
				EIIAGABAFEC = other.EIIAGABAFEC;
			}
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
			case 24u:
				MapId = input.ReadUInt32();
				break;
			case 48u:
				EIIAGABAFEC = input.ReadUInt32();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
