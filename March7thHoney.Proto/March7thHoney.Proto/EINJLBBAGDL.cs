using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EINJLBBAGDL : IMessage<EINJLBBAGDL>, IMessage, IEquatable<EINJLBBAGDL>, IDeepCloneable<EINJLBBAGDL>, IBufferMessage
{
	private static readonly MessageParser<EINJLBBAGDL> _parser = new MessageParser<EINJLBBAGDL>(() => new EINJLBBAGDL());

	private UnknownFieldSet _unknownFields;

	public const int DPBMAFBAJHDFieldNumber = 2;

	private uint dPBMAFBAJHD_;

	public const int MapIdFieldNumber = 15;

	private uint mapId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EINJLBBAGDL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EINJLBBAGDLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DPBMAFBAJHD
	{
		get
		{
			return dPBMAFBAJHD_;
		}
		set
		{
			dPBMAFBAJHD_ = value;
		}
	}

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
	public EINJLBBAGDL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EINJLBBAGDL(EINJLBBAGDL other)
		: this()
	{
		dPBMAFBAJHD_ = other.dPBMAFBAJHD_;
		mapId_ = other.mapId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EINJLBBAGDL Clone()
	{
		return new EINJLBBAGDL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EINJLBBAGDL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EINJLBBAGDL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DPBMAFBAJHD != other.DPBMAFBAJHD)
		{
			return false;
		}
		if (MapId != other.MapId)
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
		if (DPBMAFBAJHD != 0)
		{
			num ^= DPBMAFBAJHD.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
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
		if (DPBMAFBAJHD != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DPBMAFBAJHD);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MapId);
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
		if (DPBMAFBAJHD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DPBMAFBAJHD);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MapId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EINJLBBAGDL other)
	{
		if (other != null)
		{
			if (other.DPBMAFBAJHD != 0)
			{
				DPBMAFBAJHD = other.DPBMAFBAJHD;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
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
			case 16u:
				DPBMAFBAJHD = input.ReadUInt32();
				break;
			case 120u:
				MapId = input.ReadUInt32();
				break;
			}
		}
	}
}
