using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DHKCDCCHLHP : IMessage<DHKCDCCHLHP>, IMessage, IEquatable<DHKCDCCHLHP>, IDeepCloneable<DHKCDCCHLHP>, IBufferMessage
{
	private static readonly MessageParser<DHKCDCCHLHP> _parser = new MessageParser<DHKCDCCHLHP>(() => new DHKCDCCHLHP());

	private UnknownFieldSet _unknownFields;

	public const int AOOMEMCCPEMFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_aOOMEMCCPEM_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> aOOMEMCCPEM_ = new RepeatedField<uint>();

	public const int IdFieldNumber = 5;

	private uint id_;

	public const int PanelIdFieldNumber = 7;

	private uint panelId_;

	public const int ProgressFieldNumber = 12;

	private uint progress_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DHKCDCCHLHP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DHKCDCCHLHPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AOOMEMCCPEM => aOOMEMCCPEM_;

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
	public uint PanelId
	{
		get
		{
			return panelId_;
		}
		set
		{
			panelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHKCDCCHLHP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHKCDCCHLHP(DHKCDCCHLHP other)
		: this()
	{
		aOOMEMCCPEM_ = other.aOOMEMCCPEM_.Clone();
		id_ = other.id_;
		panelId_ = other.panelId_;
		progress_ = other.progress_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHKCDCCHLHP Clone()
	{
		return new DHKCDCCHLHP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DHKCDCCHLHP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DHKCDCCHLHP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aOOMEMCCPEM_.Equals(other.aOOMEMCCPEM_))
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (Progress != other.Progress)
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
		num ^= aOOMEMCCPEM_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
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
		aOOMEMCCPEM_.WriteTo(ref output, _repeated_aOOMEMCCPEM_codec);
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Id);
		}
		if (PanelId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(PanelId);
		}
		if (Progress != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Progress);
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
		num += aOOMEMCCPEM_.CalculateSize(_repeated_aOOMEMCCPEM_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DHKCDCCHLHP other)
	{
		if (other != null)
		{
			aOOMEMCCPEM_.Add(other.aOOMEMCCPEM_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.PanelId != 0)
			{
				PanelId = other.PanelId;
			}
			if (other.Progress != 0)
			{
				Progress = other.Progress;
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
			case 32u:
			case 34u:
				aOOMEMCCPEM_.AddEntriesFrom(ref input, _repeated_aOOMEMCCPEM_codec);
				break;
			case 40u:
				Id = input.ReadUInt32();
				break;
			case 56u:
				PanelId = input.ReadUInt32();
				break;
			case 96u:
				Progress = input.ReadUInt32();
				break;
			}
		}
	}
}
