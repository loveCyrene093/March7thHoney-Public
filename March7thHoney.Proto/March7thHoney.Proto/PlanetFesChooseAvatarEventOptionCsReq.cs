using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesChooseAvatarEventOptionCsReq : IMessage<PlanetFesChooseAvatarEventOptionCsReq>, IMessage, IEquatable<PlanetFesChooseAvatarEventOptionCsReq>, IDeepCloneable<PlanetFesChooseAvatarEventOptionCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesChooseAvatarEventOptionCsReq> _parser = new MessageParser<PlanetFesChooseAvatarEventOptionCsReq>(() => new PlanetFesChooseAvatarEventOptionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NHDBKGMGELHFieldNumber = 10;

	private uint nHDBKGMGELH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesChooseAvatarEventOptionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesChooseAvatarEventOptionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NHDBKGMGELH
	{
		get
		{
			return nHDBKGMGELH_;
		}
		set
		{
			nHDBKGMGELH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesChooseAvatarEventOptionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesChooseAvatarEventOptionCsReq(PlanetFesChooseAvatarEventOptionCsReq other)
		: this()
	{
		nHDBKGMGELH_ = other.nHDBKGMGELH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesChooseAvatarEventOptionCsReq Clone()
	{
		return new PlanetFesChooseAvatarEventOptionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesChooseAvatarEventOptionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesChooseAvatarEventOptionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NHDBKGMGELH != other.NHDBKGMGELH)
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
		if (NHDBKGMGELH != 0)
		{
			num ^= NHDBKGMGELH.GetHashCode();
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
		if (NHDBKGMGELH != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(NHDBKGMGELH);
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
		if (NHDBKGMGELH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NHDBKGMGELH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesChooseAvatarEventOptionCsReq other)
	{
		if (other != null)
		{
			if (other.NHDBKGMGELH != 0)
			{
				NHDBKGMGELH = other.NHDBKGMGELH;
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
			if (num != 80)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				NHDBKGMGELH = input.ReadUInt32();
			}
		}
	}
}
