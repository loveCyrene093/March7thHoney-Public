using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ActiveActivityData : IMessage<ActiveActivityData>, IMessage, IEquatable<ActiveActivityData>, IDeepCloneable<ActiveActivityData>, IBufferMessage
{
	private static readonly MessageParser<ActiveActivityData> _parser = new MessageParser<ActiveActivityData>(() => new ActiveActivityData());

	private UnknownFieldSet _unknownFields;

	public const int OKKJLFKLHBHFieldNumber = 2;

	private uint oKKJLFKLHBH_;

	public const int PanelIdFieldNumber = 5;

	private uint panelId_;

	public const int IdFieldNumber = 6;

	private uint id_;

	public const int TakenStarRewardsFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_takenStarRewards_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> takenStarRewards_ = new RepeatedField<uint>();

	public const int PGDGGAPFPBNFieldNumber = 8;

	private uint pGDGGAPFPBN_;

	public const int ACLBMIEHBJEFieldNumber = 12;

	private uint aCLBMIEHBJE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ActiveActivityData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ActiveActivityDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OKKJLFKLHBH
	{
		get
		{
			return oKKJLFKLHBH_;
		}
		set
		{
			oKKJLFKLHBH_ = value;
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
	public RepeatedField<uint> TakenStarRewards => takenStarRewards_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PGDGGAPFPBN
	{
		get
		{
			return pGDGGAPFPBN_;
		}
		set
		{
			pGDGGAPFPBN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ACLBMIEHBJE
	{
		get
		{
			return aCLBMIEHBJE_;
		}
		set
		{
			aCLBMIEHBJE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActiveActivityData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActiveActivityData(ActiveActivityData other)
		: this()
	{
		oKKJLFKLHBH_ = other.oKKJLFKLHBH_;
		panelId_ = other.panelId_;
		id_ = other.id_;
		takenStarRewards_ = other.takenStarRewards_.Clone();
		pGDGGAPFPBN_ = other.pGDGGAPFPBN_;
		aCLBMIEHBJE_ = other.aCLBMIEHBJE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActiveActivityData Clone()
	{
		return new ActiveActivityData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ActiveActivityData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ActiveActivityData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OKKJLFKLHBH != other.OKKJLFKLHBH)
		{
			return false;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (!takenStarRewards_.Equals(other.takenStarRewards_))
		{
			return false;
		}
		if (PGDGGAPFPBN != other.PGDGGAPFPBN)
		{
			return false;
		}
		if (ACLBMIEHBJE != other.ACLBMIEHBJE)
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
		if (OKKJLFKLHBH != 0)
		{
			num ^= OKKJLFKLHBH.GetHashCode();
		}
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= takenStarRewards_.GetHashCode();
		if (PGDGGAPFPBN != 0)
		{
			num ^= PGDGGAPFPBN.GetHashCode();
		}
		if (ACLBMIEHBJE != 0)
		{
			num ^= ACLBMIEHBJE.GetHashCode();
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
		if (OKKJLFKLHBH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(OKKJLFKLHBH);
		}
		if (PanelId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(PanelId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Id);
		}
		takenStarRewards_.WriteTo(ref output, _repeated_takenStarRewards_codec);
		if (PGDGGAPFPBN != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PGDGGAPFPBN);
		}
		if (ACLBMIEHBJE != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ACLBMIEHBJE);
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
		if (OKKJLFKLHBH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OKKJLFKLHBH);
		}
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		num += takenStarRewards_.CalculateSize(_repeated_takenStarRewards_codec);
		if (PGDGGAPFPBN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PGDGGAPFPBN);
		}
		if (ACLBMIEHBJE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ACLBMIEHBJE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ActiveActivityData other)
	{
		if (other != null)
		{
			if (other.OKKJLFKLHBH != 0)
			{
				OKKJLFKLHBH = other.OKKJLFKLHBH;
			}
			if (other.PanelId != 0)
			{
				PanelId = other.PanelId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			takenStarRewards_.Add(other.takenStarRewards_);
			if (other.PGDGGAPFPBN != 0)
			{
				PGDGGAPFPBN = other.PGDGGAPFPBN;
			}
			if (other.ACLBMIEHBJE != 0)
			{
				ACLBMIEHBJE = other.ACLBMIEHBJE;
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
				OKKJLFKLHBH = input.ReadUInt32();
				break;
			case 40u:
				PanelId = input.ReadUInt32();
				break;
			case 48u:
				Id = input.ReadUInt32();
				break;
			case 56u:
			case 58u:
				takenStarRewards_.AddEntriesFrom(ref input, _repeated_takenStarRewards_codec);
				break;
			case 64u:
				PGDGGAPFPBN = input.ReadUInt32();
				break;
			case 96u:
				ACLBMIEHBJE = input.ReadUInt32();
				break;
			}
		}
	}
}
