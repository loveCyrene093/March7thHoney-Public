using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesUpgradeFesLevelCsReq : IMessage<PlanetFesUpgradeFesLevelCsReq>, IMessage, IEquatable<PlanetFesUpgradeFesLevelCsReq>, IDeepCloneable<PlanetFesUpgradeFesLevelCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesUpgradeFesLevelCsReq> _parser = new MessageParser<PlanetFesUpgradeFesLevelCsReq>(() => new PlanetFesUpgradeFesLevelCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ODADJILOEKOFieldNumber = 11;

	private uint oDADJILOEKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesUpgradeFesLevelCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesUpgradeFesLevelCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ODADJILOEKO
	{
		get
		{
			return oDADJILOEKO_;
		}
		set
		{
			oDADJILOEKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesUpgradeFesLevelCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesUpgradeFesLevelCsReq(PlanetFesUpgradeFesLevelCsReq other)
		: this()
	{
		oDADJILOEKO_ = other.oDADJILOEKO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesUpgradeFesLevelCsReq Clone()
	{
		return new PlanetFesUpgradeFesLevelCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesUpgradeFesLevelCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesUpgradeFesLevelCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ODADJILOEKO != other.ODADJILOEKO)
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
		if (ODADJILOEKO != 0)
		{
			num ^= ODADJILOEKO.GetHashCode();
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
		if (ODADJILOEKO != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ODADJILOEKO);
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
		if (ODADJILOEKO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODADJILOEKO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesUpgradeFesLevelCsReq other)
	{
		if (other != null)
		{
			if (other.ODADJILOEKO != 0)
			{
				ODADJILOEKO = other.ODADJILOEKO;
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
			if (num != 88)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				ODADJILOEKO = input.ReadUInt32();
			}
		}
	}
}
